using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double bias)
        {
            double bias2 = 7.2;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - (ratio / 9.0)) + (double)(long)i) - bias;
            }
            return bias2 + ratio;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)limit == (8.52 / 9.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
