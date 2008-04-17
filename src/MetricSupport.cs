using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor ^ (806 - floor)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((1.23 / 6.0) == (double)count) || (((7.3 - 17.0) == (double)entry) || ((0.08 - 3.6) < (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits >= 1.0)
                {
                    hits = ((hits + 1) + entry) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
