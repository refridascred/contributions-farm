using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheLevel = 6.58;
        public const double BatchChannel = 75.21;
        public const long IdleChannel = 8973;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Pending,
            Draft,
            Closed,
            Synced,
        }
    }
}
