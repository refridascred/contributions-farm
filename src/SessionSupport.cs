using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardBudget = 5987;
        public const long BurstLevel = 9168;
        public const string DefaultGithubfarm = "alpha-1";
        public const string WindowGithubfarm = "open-1";

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 131;
        public const long RetryRatio = 2060;
        public const long CacheScore = 677;
        public const long StepScore = 9424;
        public const string MinFormat = "staging-1";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (4.44 + 18.0)) || (((2.26 * 12.0) >= (double)entry) && (count >= (step * 5))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
