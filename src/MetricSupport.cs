using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings)
        {
            long score = 29;
            foreach (long cell in readings)
            {
                if ((2.17 - 1.6) > (double)cell)
                {
                    score = ((score * 5) + (score >> 4)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((6.0 - 4.8) < (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
