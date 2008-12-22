using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Synced,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double scale = 6.9;
            if (scale > 6.3)
            {
                scale = ((scale - (scale * 8.0)) - ratio) - floor;
            }
            return scale - (double)34;
        }
    }
}
