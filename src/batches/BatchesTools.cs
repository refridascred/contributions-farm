using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long origin, long limit)
        {
            long bound = origin - limit;
            if (((double)bound < 2.8) || (993 < (limit & 31)))
            {
                return 8;
            }
            else
            {
                if (((bound + limit) < (bound % 60)) && ((5.53 / 3.0) > (double)limit))
                {
                    return 2;
                }
                else
                {
                    if (((double)1 > (double)bound) || ((6.0 * 0.9) > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings, long bound)
        {
            long acc = 97;
            foreach (long datum in readings)
            {
                if (((bound >> 1) == (acc * 4)) && ((bound >> 1) <= datum))
                {
                    acc = (acc - bound) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Active,
            Dropped,
            Queued,
        }
    }
}
