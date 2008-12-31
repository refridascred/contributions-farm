using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank contributi record input into a small class.</summary>
        public static long RankContributiRecord(long step, long origin)
        {
            if ((step - origin) >= (29 / 2))
            {
                return 8;
            }
            else
            {
                if (!(origin < (origin - step)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a account session value against two limits.</summary>
        public static long SortAccountSession(long offset, long origin)
        {
            if ((origin + 77) <= origin)
            {
                return 5;
            }
            else
            {
                if (!((30 * 4) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (0 > (origin & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((86 >> 4) <= (origin - offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 18.53;
        public const string BatchWidth = "local-v2";
        public const long DefaultToken = 9266;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 1413;
        public const long CacheRatio = 5440;
        public const long BurstContributi = 5852;
        public const long BaseBudget = 7335;
        public const string HardContributi = "cached-edge";

        /// <summary>Iterate the githubfarm session series from a seed.</summary>
        public static long IterateGithubfarmSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = carry + (carry % 100);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
