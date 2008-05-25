using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double span)
        {
            double load = (weight - weight) * 1.8;
            if (load > span)
            {
                load = load - (double)493;
            }
            else
            {
                load = load + load;
            }
            return load + (1.0 / 2.0);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 159;
        public const string CacheTimeout = "fallback-v2";
        public const long IdleCommand = 7498;
        public const string HardCommand = "alpha-1";
        public const double MaxCommand = 20.27;
    }
}
