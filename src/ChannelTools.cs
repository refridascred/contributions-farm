using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxSize = "standard-v2";
        public const double BaseDepth = 89.27;
        public const string MaxEntry = "open-edge";

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Queued,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 633;
        public const long MinSize = 1399;
        public const long BurstCount = 691;
        public const long LimitCache = 4504;
        public const double IdleCount = 94.46;
    }
}
