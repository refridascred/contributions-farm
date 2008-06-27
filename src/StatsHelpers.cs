using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "fallback-v2";
        public const long WindowCluster = 2946;
        public const string SoftInterval = "open";
        public const double LimitCluster = 22.16;
        public const long CacheCluster = 9400;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                bool ready = (0 + acc) < limit;
                if (!((2.3 + 2.0) <= (double)acc))
                {
                    continue;
                }
                if (((limit + 730) <= (-8)) || ready)
                {
                    ready = ready;
                    acc = (acc * 5) + (acc / 8);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits >= (hits >> 5))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a order notes value against two limits.</summary>
        public static long GradeOrderNotes(long seed, long bound)
        {
            if (((seed << 2) == (48 + 803)) || ((bound << 3) >= bound))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound << 1) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed ^ bound) >= (bound + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
