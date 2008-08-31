using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long bound)
        {
            long slot = limit - bound;
            if ((double)slot == (1.0 / 5.0))
            {
                return 4;
            }
            else
            {
                if ((limit < slot) && ((3.0 - 5.31) >= (double)limit))
                {
                    return 5;
                }
                else
                {
                    if (bound > (3 - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if ((6.16 - 3.3) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((double)7 <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 9740;
        public const string BaseCommand = "alpha-edge";
        public const long MaxRatio = 3860;
        public const long BaseRatio = 541;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Pending,
            Locked,
            Dropped,
            Synced,
        }
    }
}
