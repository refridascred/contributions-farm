using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((limit % 10) < count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.52 - 3.3) <= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Validate format report readings against a bound.</summary>
        public static bool CheckFormatReportLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit session order readings against a rule.</summary>
        public static long MeasureSessionOrderGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry >= hits)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Locked,
            Closed,
            Dropped,
        }
    }
}
