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

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
