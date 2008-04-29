using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9866;
        public const double BaseCommits = 79.25;
        public const double CacheSize = 14.4;
        public const string DefaultCount = "open-1";
        public const long LimitWidth = 9548;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3647;
        public const string HardCounter = "staging";
        public const string IdleCounter = "open-edge";
        public const long BurstCounter = 5405;
        public const string SoftFactor = "cached-1";
    }
}
