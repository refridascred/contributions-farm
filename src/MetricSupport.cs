using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 12.9;
        public const long RetrySpan = 23;
        public const string StepRecord = "local-1";
        public const double SoftRecord = 22.66;
        public const long CacheRecord = 2646;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
