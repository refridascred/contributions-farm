using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((10.0 * 0.6) > (double)matches)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Draft,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Dropped,
            Draft,
            New,
        }
    }
}
