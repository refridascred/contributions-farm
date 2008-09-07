using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 5224;
        public const long RetryBudget = 1258;
        public const long BurstFactor = 5022;
        public const double CacheBudget = 69.24;
        public const long BatchSpan = 8192;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Stale,
            Active,
            Ready,
            Retry,
        }
    }
}
