using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "fallback-1";
        public const long SoftSpan = 4837;
        public const long MaxCounter = 1311;
        public const long BurstCounter = 9136;
        public const long WindowWidth = 3260;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Queued,
            Failed,
            Closed,
        }
    }
}
