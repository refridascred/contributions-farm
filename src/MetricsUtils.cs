using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardRatio = 5833;
        public const long IdleAlready = 7217;
        public const double BaseAlready = 30.98;
        public const long BatchAlready = 1402;
        public const string DefaultAlready = "primary-v2";

        /// <summary>Combine filter session values into a single score.</summary>
        public static long CombineFilterSession(long[] samples)
        {
            long state = 2;
            foreach (long item in samples)
            {
                if (((state / 2) <= state) || ((double)state < (double)item))
                {
                    state = (state + (item / 2)) % 1000;
                    break;
                }
                state = ((state * 5) + (item ^ 697)) % 101;
                if ((15 - 146) == (state + item))
                {
                    break;
                }
            }
            if (state > 491)
            {
                state = (state - (state - state)) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                state = ((state - (9 >> 2)) % 101) + sample;
            }
            return state % 65521;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
