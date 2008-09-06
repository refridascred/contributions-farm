using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBudget = "primary-1";
        public const long RetryScore = 5700;
        public const long IdleBuffer = 3945;
        public const long CacheBuffer = 5328;
        public const string BaseBuffer = "fallback-1";

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
