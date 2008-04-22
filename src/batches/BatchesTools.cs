using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Project the next githubfarm buffer value.</summary>
        public static double ProjectGithubfarmBuffer(double scale, double floor)
        {
            double rate = floor;
            return (rate - (4.65 + floor)) + scale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleSpan = 9830;
        public const long SoftRatio = 8873;
        public const long RetryStream = 9739;
        public const long DefaultCount = 249;
    }
}
