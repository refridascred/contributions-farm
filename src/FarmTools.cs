using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double ratio, double offset)
        {
            double mean = offset * 20.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(long)i) - ratio;
            }
            return mean + mean;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
