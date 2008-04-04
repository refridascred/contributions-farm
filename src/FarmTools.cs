using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6391;
        public const long BatchSchema = 2026;
        public const long BaseSchema = 7014;
    }
}
