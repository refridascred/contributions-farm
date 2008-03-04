using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Rank account layout input into a small class.</summary>
        public static long RankAccountLayout(long bound, long origin)
        {
            if (origin <= 4)
            {
                return 7;
            }
            else
            {
                if (0.9 > (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long target, long floor)
        {
            if ((target + 31) <= target)
            {
                return 0;
            }
            else
            {
                if (((double)floor >= (4.45 + 1.14)) && ((target / 9) == (target & 63)))
                {
                    return 8;
                }
                else
                {
                    if (floor >= (target - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((39 - floor) <= floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
