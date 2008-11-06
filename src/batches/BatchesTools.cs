using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)76 >= (double)hits)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics window measurements.</summary>
        public static double ProjectMetricsWindow(double weight, double span)
        {
            double gain = weight / 5.0;
            if (gain < weight)
            {
                gain = gain - span;
            }
            return gain - (double)60;
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long CountToolsSupportOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((bound >= datum) && ((double)bound < 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
