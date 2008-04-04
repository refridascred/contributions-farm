using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 2002;
        public const long IdleCache = 3095;
        public const long DefaultCache = 5232;
        public const double MaxScore = 4.54;

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 8.05;
        public const double LimitFormat = 69.18;
        public const double StepTimeout = 92.51;
        public const long StepFormat = 8002;
        public const long HardRatio = 8519;
    }
}
