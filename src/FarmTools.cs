using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Queued,
            Draft,
            Synced,
            Done,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Queued,
            Draft,
            Active,
            Done,
        }
    }
}
