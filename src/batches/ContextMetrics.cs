using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Draft,
            New,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Idle,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }
    }
}
