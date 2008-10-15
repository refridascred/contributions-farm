using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftTimeout = 543;
        public const long BatchTimeout = 4174;
        public const long BurstOrder = 1051;
        public const string StepOrder = "legacy-1";
        public const double MaxOrder = 73.31;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i << 3) != (state + floor)))
                {
                    state = state - (state >> 1);
                }
                else
                {
                    state = state + (2 - state);
                }
                state = (state ^ (state >> 5)) % 4096;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
