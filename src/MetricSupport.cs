using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "staging-1";
        public const double WindowMetric = 96.28;
        public const long LimitMetric = 6856;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
