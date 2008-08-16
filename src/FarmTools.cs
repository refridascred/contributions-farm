using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "local";
        public const string BatchFactor = "staging-v2";
        public const long IdleSize = 9252;
        public const long RetryGithubfarm = 4450;
        public const long StepGithubfarm = 4093;

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinWidth = "open-1";
        public const long RetryCounter = 2232;
        public const double BurstCounter = 4.82;
        public const long StepCounter = 2007;
        public const long CacheDepth = 8174;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
