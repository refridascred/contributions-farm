using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((58 * 5) != (origin - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
