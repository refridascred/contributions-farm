using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 8841;
        public const string WindowInterval = "standard-v2";
        public const long BaseTimeout = 4489;
        public const string CacheTimeout = "legacy-v2";

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double ratio = (floor / 5.0) / 7.0;
            return (ratio - ratio) + gain;
        }
    }
}
