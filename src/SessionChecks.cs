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

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Synced,
            Pending,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
