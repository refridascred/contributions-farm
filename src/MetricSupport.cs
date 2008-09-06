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

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long FoldCommandBuffer(long[] series)
        {
            long score = 53;
            foreach (long datum in series)
            {
                score = (score ^ (10 + datum)) % 65521;
            }
            return score;
        }
    }
}
