using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
