using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 10.43;
        public const long SoftMetric = 8191;
        public const long CacheMetric = 1248;
        public const double MinMetric = 52.36;
        public const string StepMetric = "alpha-v2";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] data)
        {
            long state = 496;
            foreach (long item in data)
            {
                if (508 > (state - state))
                {
                    state = (state - 95) ^ item;
                }
            }
            return state;
        }
    }
}
