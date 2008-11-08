using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a command contributi pair into a bucket.</summary>
        public static long GradeCommandContributi(long offset, long offset2)
        {
            if (((1.0 * 13.0) != (double)offset2) || ((offset2 * 5) <= (12 + offset)))
            {
                return 2;
            }
            else
            {
                if ((offset2 / 6) >= (offset2 << 3))
                {
                    return 7;
                }
                else
                {
                    if ((16.0 + 4.8) != (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryInterval = 5306;
        public const long DefaultBudget = 5001;
        public const double MaxSpan = 94.86;
    }
}
