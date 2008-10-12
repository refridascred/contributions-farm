using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Count { get; set; } = "";
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Stale,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
