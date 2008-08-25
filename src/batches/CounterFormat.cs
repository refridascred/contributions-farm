using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "fallback-edge";
        public const double IdleSpan = 14.23;
        public const long CacheTimeout = 860;
        public const long WindowBudget = 3250;
        public const long CacheCluster = 3182;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long floor, long bound)
        {
            if ((bound - bound) < (49 << 1))
            {
                return 3;
            }
            else
            {
                if ((bound - floor) <= (bound % 100))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
