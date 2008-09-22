using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Stale,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Failed,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "staging-1";
        public const long IdleDepth = 7870;
        public const long MaxBudget = 6614;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
