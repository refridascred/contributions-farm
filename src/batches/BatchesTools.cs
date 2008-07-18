using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate report cache readings against a bound.</summary>
        public static bool GuardReportCacheBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double mean = span;
            return (mean - 8.0) + ratio;
        }
    }
}
