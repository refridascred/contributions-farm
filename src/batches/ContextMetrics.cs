using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 1308;
        public const long WindowToken = 242;
        public const long WindowCount = 6016;
        public const double CacheToken = 68.27;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series)
        {
            long carry = 12;
            foreach (long item in series)
            {
                if (item <= (34 % 10))
                {
                    carry = carry + (carry + carry);
                }
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 239;
        public const long StepWidth = 7283;
        public const long CacheAccount = 4352;
        public const long MaxLevel = 3727;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
