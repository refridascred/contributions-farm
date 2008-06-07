using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8857;
        public const long IdleMetrics = 4032;
        public const long RetryBudget = 8590;
        public const string RetrySpan = "cached-v2";
        public const long HardMetrics = 9833;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
