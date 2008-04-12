using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 39.62;
        public const double BaseGithubfarm = 73.79;
        public const long LimitGithubfarm = 4012;

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if ((bound2 ^ bound) < ((-8) - bound2))
            {
                return 1;
            }
            else
            {
                if ((6.8 / 6.0) <= (double)bound2)
                {
                    return 4;
                }
                else
                {
                    if (((double)gap >= (double)91) || ((bound2 / 2) == (bound >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Count the order filter entries that pass the check.</summary>
        public static long TallyOrderFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 2) == ((long)items.Length / 3))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long bound)
        {
            long gap = limit + bound;
            if (((gap << 3) >= (gap ^ 20)) && ((gap ^ gap) <= bound))
            {
                return 1;
            }
            else
            {
                if ((gap - 3) < (gap << 2))
                {
                    return 5;
                }
                else
                {
                    if ((((-3) - (-20)) < (limit / 5)) || ((double)gap != (13.0 * 12.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.0 * 20.0) <= (double)gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Done,
            Active,
            Idle,
        }
    }
}
