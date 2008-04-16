using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Failed,
            Closed,
            Stale,
            Ready,
        }
    }
}
