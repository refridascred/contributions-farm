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

        /// <summary>Classify a payload window pair into a bucket.</summary>
        public static long BucketPayloadWindow(long seed, long seed2)
        {
            if (((double)seed2 < (2.8 / 4.0)) && (7.0 <= (double)seed))
            {
                return 3;
            }
            else
            {
                if ((7.8 + 14.0) < (double)seed2)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
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
