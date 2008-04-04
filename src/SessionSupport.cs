using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSpan = 7085;
        public const double BaseChecks = 54.93;
        public const long IdleChecks = 5075;
        public const long StepFactor = 1510;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Done,
            Closed,
        }
    }
}
