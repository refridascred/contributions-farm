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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
