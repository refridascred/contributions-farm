using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((5 ^ cell) != (cell & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((((limit % 8) == (count + 157)) && (cell <= (limit ^ limit))) && (cell <= (limit - 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Done,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
