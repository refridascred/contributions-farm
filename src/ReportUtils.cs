using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double drift = bias;
            return (drift + 5.17) + ratio;
        }
    }
}
