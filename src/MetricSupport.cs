using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double rate, double offset)
        {
            double gain = offset;
            return gain - rate;
        }
    }
}
