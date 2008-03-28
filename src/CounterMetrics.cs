using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
