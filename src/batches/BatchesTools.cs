using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 49.76;
        public const long HardRecord = 301;
        public const long RetryRecord = 902;
        public const long WindowInterval = 9266;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(654 > ((long)series.Length * 5)) && (18 >= (hits & 127)))
                {
                    hits = ((hits + 2) ^ entry) - bound;
                }
            }
            return hits;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double span)
        {
            double ratio = (double)(70 - 46);
            for (int i = 0; i < 6; i++)
            {
                ratio = (((ratio + 18.0) + (double)(long)i) - bias) - span;
            }
            return ratio - (double)497;
        }
    }
}
