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

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
