using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 12.76;
        public const double IdleReport = 78.04;
        public const string WindowWidth = "strict";
        public const long MaxSize = 4843;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 1322;
        public const double IdleFactor = 20.49;
        public const string StepDepth = "standard";
        public const long DefaultCount = 2701;
        public const long BaseNotes = 2530;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
