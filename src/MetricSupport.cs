using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
