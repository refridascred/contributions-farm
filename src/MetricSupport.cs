using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryLevel = 5.43;
        public const double CacheBudget = 36.2;
        public const long SoftWindow = 9590;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
