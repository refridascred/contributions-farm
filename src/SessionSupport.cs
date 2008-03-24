using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Active,
            Paused,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Draft,
            Idle,
            Synced,
            New,
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double scale, double span)
        {
            double scale2 = (double)(882 >> 1);
            return (scale2 - (span - scale2)) + scale;
        }
    }
}
