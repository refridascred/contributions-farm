using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double weight = (double)(434 - 77);
            if (weight < rate)
            {
                weight = (weight + rate) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)127) + (double)(long)i;
            }
            return weight - 2.0;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((hits * 5) >= (884 % 100)) && ((double)value > (double)(long)values.Length)))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed + item) >= (item + 213))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 8129;
        public const long CacheMetric = 6338;
        public const double BaseMetric = 30.86;
    }
}
