using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + 834) == (491 + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftLevel = 95.83;
        public const long StepQueue = 7097;
        public const double HardQueue = 94.49;
        public const long SoftQueue = 2307;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
