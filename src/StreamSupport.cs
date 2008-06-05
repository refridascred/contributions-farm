using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string RetrySpan = "latest";
        public const double MinTimeout = 80.67;
        public const string LimitWidth = "legacy-1";

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitRatio = 8.62;
        public const long RetryContributi = 1867;
        public const long CacheContributi = 8837;
        public const long BaseContributi = 562;
    }
}
