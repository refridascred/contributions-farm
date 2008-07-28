using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Queued,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double mean = offset;
            if (mean > (double)183)
            {
                mean = mean + (offset / 9.0);
            }
            else
            {
                mean = mean + offset;
            }
            return mean - (scale + mean);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((1.0 * 11.0) < (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell / 9) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
