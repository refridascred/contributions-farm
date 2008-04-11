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

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultCount = "legacy-1";
        public const long WindowLevel = 2249;
        public const double BatchGraph = 26.34;

        /// <summary>Define account limits and defaults.</summary>
        public const string StepDepth = "strict";
        public const double CacheWidth = 64.21;
        public const string MinAccount = "cached";

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
