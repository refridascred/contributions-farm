using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftLevel = "open-v2";
        public const double RetryCluster = 19.73;
        public const long MaxSpan = 9140;
        public const long LimitCluster = 948;

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheSpan = "staging-1";
        public const long LimitSpan = 5526;
        public const long CacheFactor = 7670;
        public const string BurstFactor = "stable-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryInterval = 7258;
        public const long SoftTimeout = 1633;
        public const long BatchLevel = 8007;
        public const double BatchChannel = 51.94;
        public const long MaxChannel = 3003;
    }
}
