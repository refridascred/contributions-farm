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

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxCount = 1099;
        public const long MinDepth = 4198;
        public const string SoftLevel = "alpha";

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 1322;
        public const double IdleFactor = 20.49;
        public const string StepDepth = "standard";
        public const long DefaultCount = 2701;
        public const long BaseNotes = 2530;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Level { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSpan = 2814;
        public const long MaxDepth = 3208;
        public const long MaxFactor = 9952;
    }
}
