using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((double)cell > 1.96))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long limit)
        {
            if ((9.5 - 2.0) != (double)limit)
            {
                return 4;
            }
            else
            {
                if ((double)target >= 7.7)
                {
                    return 0;
                }
                else
                {
                    if (!((double)target < (0.1 - 1.6)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxScore = "cached";
        public const double SoftPayload = 66.73;
        public const double MaxPayload = 51.72;

        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long FoldGithubfarmPayload(long[] series, long limit)
        {
            long anchor = 43;
            foreach (long cell in series)
            {
                if ((cell - anchor) > 0)
                {
                    anchor = (anchor - (cell * 2)) % 65521;
                }
                if ((9 ^ limit) < (49 >> 3))
                {
                    anchor = (anchor * 2) + limit;
                }
                if ((cell - cell) > limit)
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ (anchor - limit);
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 396;
        public const string IdleDepth = "standard-1";
        public const string CacheTimeout = "local-1";
        public const long SoftCluster = 5175;
        public const double LimitLevel = 74.55;

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long limit)
        {
            if (((44 + bound) <= (limit + limit)) && ((limit % 12) < bound))
            {
                return 8;
            }
            else
            {
                if ((5.9 + 4.69) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound - 118) <= (88 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
