using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((3.4 + 4.0) == (double)offset)
            {
                return 0;
            }
            else
            {
                if ((bound + edge) == (offset + 658))
                {
                    return 1;
                }
                else
                {
                    if ((bound - edge) >= (-97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound > (8.0 * 8.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels, long origin)
        {
            long acc = 261;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length >= (6.0 - 2.0))
                {
                    acc = acc + (cell / 9);
                }
                else
                {
                    acc = (acc ^ (cell / 6)) % 1000;
                }
                if (origin > (acc + origin))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((hits + hits) > 6) && ((cell - hits) > ((long)values.Length % 2))) || ((double)hits < 5.1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Pending,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
