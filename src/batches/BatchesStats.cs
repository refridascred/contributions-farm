using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Pending,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryFactor = 150;
        public const long CacheCount = 8669;
        public const long MaxReport = 9646;
        public const double StepDepth = 79.76;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 36.55;
        public const long CacheMetrics = 1636;
        public const long BaseMetrics = 3115;
        public const string StepBudget = "cached-1";
    }
}
