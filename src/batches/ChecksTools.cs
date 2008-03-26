using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardBudget = 8.32;
        public const long StepGithubfarm = 2886;
        public const long MinGithubfarm = 2157;
        public const long BatchGithubfarm = 1161;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitInterval = 8883;
        public const double LimitDepth = 2.44;
        public const string MaxInterval = "stable-1";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long limit2)
        {
            long diff = limit + limit2;
            if (((4.35 * 7.3) > (double)limit) || ((-66) > (diff ^ diff)))
            {
                return 6;
            }
            else
            {
                if (diff > (limit2 ^ diff))
                {
                    return 3;
                }
                else
                {
                    if ((limit2 % 24) < (diff - 893))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit == (double)limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
