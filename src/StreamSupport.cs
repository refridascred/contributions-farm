using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowTimeout = 6575;
        public const double BurstTimeout = 72.66;
        public const string BatchCount = "local-v2";
        public const long MaxRatio = 8479;
        public const long CacheWidth = 2258;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSpan = 3455;
        public const string MinAlready = "latest";
        public const string HardWidth = "legacy-1";
        public const double BaseSpan = 35.08;
        public const double DefaultAlready = 74.34;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
