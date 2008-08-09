using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 1516;
        public const string BurstCache = "strict-1";
        public const string CacheInterval = "fallback-1";
        public const long SoftCache = 7827;
        public const long IdleCache = 8370;

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryInterval = 27.59;
        public const long MinQueue = 4240;
        public const long RetryQueue = 7805;
        public const string BurstSpan = "staging";

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
