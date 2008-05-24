using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a batches order figure with a bias.</summary>
        public static double SmoothBatchesOrder(double bias, double offset)
        {
            double gain = (3.05 / 2.0) / 6.0;
            return ((gain - (gain * 4.4)) + bias) + offset;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Failed,
            New,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
