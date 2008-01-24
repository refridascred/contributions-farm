using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Active,
            Idle,
            New,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Done,
            Closed,
            Stale,
        }
    }
}
