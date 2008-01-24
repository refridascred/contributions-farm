using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long AuditWindowStreamHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample <= (bound - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter already samples.</summary>
        public static long DigestCounterAlready(long[] items, long origin)
        {
            long anchor = 790;
            foreach (long item in items)
            {
                if (10.0 <= (double)item)
                {
                    anchor = (anchor - (origin ^ item)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((((item + 72) <= (step * 3)) || ((double)item < (8.5 / 5.0))) || (item > step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long limit)
        {
            if ((40 >> 5) > limit)
            {
                return 6;
            }
            else
            {
                if (offset > (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (((51 + offset) >= limit) && (offset < (380 ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
