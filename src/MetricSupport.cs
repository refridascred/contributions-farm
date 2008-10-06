using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Failed,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Adjust a report cluster reading.</summary>
        public static double ProjectReportCluster(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 - scale) + (double)(long)i) + offset;
            }
            return scale2 - (scale - scale);
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
