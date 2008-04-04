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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (1.8 >= (double)hits)
                {
                    hits = ((hits + 1) ^ cell) + seed;
                }
            }
            return hits;
        }
    }
}
