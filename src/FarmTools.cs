using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
