using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Dropped,
            Ready,
            New,
            Done,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double gain = (double)(96 & 255);
            if (gain >= (gain + floor))
            {
                gain = (gain - (floor * 1.98)) + weight;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (7.6 / 4.0);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Done,
        }
    }
}
