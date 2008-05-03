using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2784;
        public const string LimitSpan = "alpha";
        public const double BaseTimeout = 66.83;
        public const string HardCommits = "legacy-1";

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3767;
        public const string DefaultSupport = "latest-v2";
        public const string MinSupport = "local";
        public const double LimitSupport = 94.33;
        public const double DefaultRatio = 60.43;
    }
}
