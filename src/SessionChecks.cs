using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "stable-edge";
        public const long WindowRatio = 7182;
        public const long DefaultGithubfarm = 7064;
        public const long MaxTimeout = 4517;
        public const double IdleCount = 90.85;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item << 1) == (seen >> 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long limit)
        {
            if ((8 + 9) > seed)
            {
                return 7;
            }
            else
            {
                if ((76 & 1) <= (seed & 63))
                {
                    return 3;
                }
                else
                {
                    if (seed <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((74 + seed) <= (limit + (-5))) && ((6 % 97) == (limit / 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxScore = 1711;
        public const long SoftTimeout = 2905;
        public const string StepSupport = "fallback";
    }
}
