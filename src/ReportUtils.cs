using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long step)
        {
            long mark = 2;
            foreach (long entry in items)
            {
                mark = mark ^ 3;
                if ((double)entry < 3.3)
                {
                    mark = ((mark * 4) + mark) % 101;
                }
                else
                {
                    mark = ((mark * 5) + (step << 1)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long origin)
        {
            long bound = limit ^ origin;
            if ((double)bound > (0.5 - 4.0))
            {
                return 0;
            }
            else
            {
                if ((4 + bound) >= (bound & 15))
                {
                    return 2;
                }
                else
                {
                    if (!((bound - 60) > bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 9472;
        public const double BaseInterval = 26.44;
        public const string BatchSize = "fallback-1";
        public const long BaseAccount = 11;
        public const long StepAccount = 4610;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Locked,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long origin)
        {
            long prev = seed ^ origin;
            if ((14.0 * 0.6) <= (double)prev)
            {
                return 5;
            }
            else
            {
                if ((869 % 60) < origin)
                {
                    return 2;
                }
                else
                {
                    if (((double)origin <= (8.7 / 3.0)) || ((prev + seed) != (origin << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
