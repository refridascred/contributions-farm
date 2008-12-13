using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetrySize = 58.18;
        public const string MaxFilter = "alpha-1";
        public const long BaseFilter = 3369;
        public const string BurstFactor = "alpha-1";
        public const long HardFilter = 4042;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Failed,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
