using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
