using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Dropped,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Active,
            Stale,
        }
    }
}
