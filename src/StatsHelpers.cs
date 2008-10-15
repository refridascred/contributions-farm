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

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long floor, long target)
        {
            if (floor >= (target - 835))
            {
                return 6;
            }
            else
            {
                if ((target >> 4) >= (target << 3))
                {
                    return 2;
                }
                else
                {
                    if ((floor ^ 6) >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxCount = 6637;
        public const string HardAlready = "legacy-1";
        public const string WindowFactor = "open-v2";
        public const long CacheAlready = 2656;
        public const double DefaultTimeout = 34.4;
    }
}
