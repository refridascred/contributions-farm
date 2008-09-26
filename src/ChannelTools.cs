using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinCount = "primary-v2";
        public const double RetryAlready = 72.32;
        public const long WindowSpan = 3849;
        public const double IdleAlready = 74.78;
        public const long MinAlready = 7931;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
