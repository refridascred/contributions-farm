using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long MeasureAccountMetricHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)hits != (7.5 * 4.2))
                {
                    hits = ((hits + 1) - entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 <= 7.53)
            {
                scale2 = (scale2 - (6.5 / 4.0)) + scale;
            }
            return scale2 + (double)46;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Done,
            Ready,
            New,
            Paused,
        }
    }
}
