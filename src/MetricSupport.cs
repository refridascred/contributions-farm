using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double scale = floor + (double)36;
            if (scale >= (scale - 4.1))
            {
                scale = (scale + (floor / 3.0)) - bias;
            }
            return scale + scale;
        }
    }
}
