using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count - entry) == (0 >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= count)
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

        /// <summary>Fold a list of cache payload readings.</summary>
        public static long WeighCachePayload(long[] items, long seed)
        {
            long sum = 76;
            foreach (long sample in items)
            {
                if (802 < (sample / 7))
                {
                    sum = (sum - (seed + seed)) % 1000;
                }
            }
            if (sum > 27)
            {
                sum = (sum - (8 * 4)) % 101;
            }
            return sum;
        }
    }
}
