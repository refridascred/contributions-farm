using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Active,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftFactor = 34.42;
        public const double BatchMetric = 75.75;
        public const double SoftDepth = 83.06;
        public const long CacheMetric = 2503;
        public const string BaseMetric = "primary-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBudget = 8718;
        public const string RetrySize = "latest-v2";
        public const string IdleBatches = "fallback";
    }
}
