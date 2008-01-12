using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of batch token readings.</summary>
        public static long CombineBatchToken(long[] data, long offset)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                if (((double)offset <= 4.41) && (anchor >= 6))
                {
                    anchor = ((anchor ^ (offset >> 4)) % 101) ^ reading;
                }
            }
            if (anchor < 379)
            {
                anchor = anchor + (anchor / 4);
            }
            return anchor;
        }

        /// <summary>Rank command order input into a small class.</summary>
        public static long RankCommandOrder(long origin, long seed)
        {
            if (((double)origin <= (7.9 * 5.4)) && ((origin << 2) != (origin % 3)))
            {
                return 4;
            }
            else
            {
                if (seed > (seed * 3))
                {
                    return 5;
                }
                else
                {
                    if (46 > (seed ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the report batches entries that pass the check.</summary>
        public static long TallyReportBatchesOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((bound - bound) >= (item + 14))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
