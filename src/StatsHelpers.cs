using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long target, long origin)
        {
            long offset = target - origin;
            if ((8.4 - 9.3) <= (double)offset)
            {
                return 1;
            }
            else
            {
                if (((offset & 31) <= 314) || ((-98) <= (target + target)))
                {
                    return 8;
                }
                else
                {
                    if ((origin + offset) != (origin >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long total = 545;
            foreach (long cell in values)
            {
                if (total > (total - cell))
                {
                    total = total + (802 + cell);
                }
            }
            if (total > 0)
            {
                total = (total << 3) ^ (total << 3);
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 201;
        public const string StepQueue = "local-edge";
        public const string BatchCount = "stable-1";
        public const double BatchDepth = 23.66;

        /// <summary>Classify a format entry pair into a bucket.</summary>
        public static long RankFormatEntry(long floor, long limit)
        {
            if (!((floor & 15) != (4 ^ limit)))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((floor * 2) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
