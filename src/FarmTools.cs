using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Idle,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinRatio = 3307;
        public const long RetryBudget = 1768;
        public const string RetryFactor = "cached";
        public const string LimitSpan = "latest-v2";
        public const long SoftGithubfarm = 9718;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (9.6 - 12.0))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
