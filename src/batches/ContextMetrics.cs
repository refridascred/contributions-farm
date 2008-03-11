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

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSpan = 2814;
        public const long MaxDepth = 3208;
        public const long MaxFactor = 9952;
    }
}
