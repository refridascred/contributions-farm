using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Closed,
            Draft,
            Ready,
            Dropped,
        }
    }
}
