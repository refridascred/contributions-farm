using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftDepth = 2690;
        public const double BaseCount = 60.26;
        public const string DefaultMetric = "alpha-1";
        public const string RetryMetric = "standard";
        public const string MinMetric = "alpha-v2";

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] series, long limit)
        {
            long score = 0;
            foreach (long sample in series)
            {
                score = ((score - (584 + score)) + sample) - limit;
            }
            return score % 4096;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Ready,
            New,
            Idle,
            Queued,
        }
    }
}
