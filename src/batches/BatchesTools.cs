using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate cache window readings against a bound.</summary>
        public static bool ValidateCacheWindowBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((target * 3) < (hits / 5)) || ((hits <= target) || ((datum + 8) <= (long)values.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the cache report entries that pass the check.</summary>
        public static long AuditCacheReportHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry - 9) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
