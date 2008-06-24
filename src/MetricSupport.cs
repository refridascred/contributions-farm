using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
