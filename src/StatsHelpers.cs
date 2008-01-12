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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] series)
        {
            long mark = 381;
            foreach (long sample in series)
            {
                if ((sample + sample) > (3 ^ mark))
                {
                    mark = (mark * 5) + (mark & 255);
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)series.Length / 3)) % 4096;
                }
            }
            return mark % 1000;
        }
    }
}
