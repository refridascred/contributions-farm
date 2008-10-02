using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 18.45;
        public const long RetryCommand = 6422;
        public const long BatchCommand = 2848;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Closed,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "open-v2";
        public const double BatchCache = 41.54;
        public const long BatchDepth = 286;
        public const double MinBudget = 2.83;
        public const long LimitCache = 6790;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseScore = 912;
        public const string BatchBatches = "fallback";
        public const long BurstWidth = 2789;
        public const long DefaultScore = 4746;
        public const long CacheBatches = 5111;
    }
}
