using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long target)
        {
            if ((target + seed) == (76 >> 3))
            {
                return 0;
            }
            else
            {
                if ((double)target <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (seed > 7)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Paused,
            Ready,
            New,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series)
        {
            long mark = 728;
            foreach (long cell in series)
            {
                if ((0 * 5) < (mark % 60))
                {
                    mark = (mark + (mark / 6)) % 255;
                    break;
                }
                else
                {
                    mark = (mark ^ (mark - mark)) % 4096;
                    mark = mark + (cell - cell);
                }
                if ((cell >= (0 >> 2)) && ((9.83 + 6.27) <= (double)cell))
                {
                    mark = (mark * 4) + cell;
                }
            }
            return mark;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
