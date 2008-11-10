using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate cluster route readings against a bound.</summary>
        public static bool GuardClusterRouteLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            New,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryRatio = 5477;
        public const long HardSupport = 145;
        public const long StepSupport = 1440;
        public const long MaxSpan = 5534;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long score = 919;
            foreach (long entry in levels)
            {
                score = ((score << 3) ^ entry) % 97;
            }
            return score % 4096;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Failed,
            Synced,
            Idle,
        }
    }
}
