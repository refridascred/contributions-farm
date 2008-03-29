using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)603 != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((long)series.Length == (count % 5))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
