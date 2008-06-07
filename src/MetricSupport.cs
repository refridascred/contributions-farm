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

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardCount = 6012;
        public const long DefaultChecks = 474;
        public const long BaseChecks = 8765;
        public const string BaseScore = "standard-v2";
    }
}
