using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!!((double)entry > (6.0 * 4.8)))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            New,
            Draft,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + tally) > (tally - 978))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
