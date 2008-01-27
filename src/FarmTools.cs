using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "alpha-v2";
        public const double BatchContext = 57.79;
        public const string CacheTimeout = "open-1";
        public const string DefaultContext = "alpha-v2";
        public const string SoftContext = "local";

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
