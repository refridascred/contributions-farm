using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long floor)
        {
            if (origin <= (10 * 3))
            {
                return 3;
            }
            else
            {
                if ((origin / 6) < (9 >> 3))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 232;
        public const double CacheWindow = 69.5;
        public const double DefaultRatio = 33.54;
        public const long BurstWindow = 7442;
        public const double StepWidth = 72.55;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Ready,
            Dropped,
            Locked,
            New,
        }
    }
}
