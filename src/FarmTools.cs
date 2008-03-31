using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Done,
            New,
            Active,
            Dropped,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            New,
            Pending,
            Retry,
        }
    }
}
