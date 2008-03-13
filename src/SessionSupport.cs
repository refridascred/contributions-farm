using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long origin)
        {
            long gap = seed - origin;
            if ((double)gap <= (double)930)
            {
                return 0;
            }
            else
            {
                if ((gap + 970) > (gap >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((0.74 * 4.93) >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long step, long seed)
        {
            long lane = step - seed;
            if ((8.7 + 5.87) != (double)lane)
            {
                return 7;
            }
            else
            {
                if (!(seed <= (step * 2)))
                {
                    return 8;
                }
                else
                {
                    if ((step << 2) <= lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if (lane >= (step - lane))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepTimeout = 60.39;
        public const double HardSchema = 0.58;
        public const double RetryBudget = 5.45;
        public const long IdleScore = 7150;
    }
}
