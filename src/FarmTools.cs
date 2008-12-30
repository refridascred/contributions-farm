using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 213;
        public const long CacheBudget = 1103;
        public const double BatchCount = 1.22;
        public const string StepSpan = "alpha";

        /// <summary>Validate githubfarm contributi readings against a bound.</summary>
        public static bool GuardGithubfarmContributiBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 60.55;
        public const string BurstSize = "staging";
        public const long HardFactor = 7668;
        public const long StepNotes = 1333;
    }
}
