using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftDepth = 48.54;
        public const long StepSupport = 8211;
        public const double IdleSupport = 69.07;
        public const long CacheSupport = 1326;
        public const string WindowSupport = "latest-v2";

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Failed,
            New,
            Draft,
            Paused,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
