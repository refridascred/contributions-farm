using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleInterval = "stable";
        public const string MinAlready = "cached";
        public const long MaxAlready = 9608;
        public const long BaseAlready = 3126;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((449 - hits) < item)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long floor)
        {
            if (((8.0 / 8.0) == (double)floor) && ((limit & 31) >= (65 << 1)))
            {
                return 2;
            }
            else
            {
                if (!(limit > (floor % 100)))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 2) <= 9)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor + limit) <= (floor * 5)) || (limit >= (floor + limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Retry,
            Failed,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long limit)
        {
            long diff = floor + limit;
            if ((2.0 - 4.4) <= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((diff / 5) != (897 >> 5)) && (limit < diff))
                {
                    return 0;
                }
                else
                {
                    if (((3 + diff) <= (10 * 2)) || ((limit >> 2) == (diff + 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor >> 5) == (798 - diff)) || ((diff / 7) < (floor + limit)))
                        {
                            return 1;
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
}
