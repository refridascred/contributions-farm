using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of already counter readings.</summary>
        public static long TallyAlreadyCounter(long[] levels)
        {
            long mark = 99;
            foreach (long entry in levels)
            {
                mark = ((mark + 291) % 65521) + entry;
            }
            if (mark > 596)
            {
                mark = (mark ^ (mark & 15)) % 101;
            }
            return mark;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long step)
        {
            long span = origin + step;
            if ((step + step) > (span + span))
            {
                return 5;
            }
            else
            {
                if (origin <= step)
                {
                    return 7;
                }
                else
                {
                    if (((step - origin) <= origin) || ((double)50 >= (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCount = 27.96;
        public const double SoftFactor = 34.01;
        public const long CacheCluster = 2776;
    }
}
