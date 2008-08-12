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

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardCount = 1553;
        public const long RetrySpan = 9785;
        public const long WindowStats = 1427;
        public const long MaxStats = 2973;

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
