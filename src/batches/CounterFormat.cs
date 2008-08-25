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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((double)datum >= (double)8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
