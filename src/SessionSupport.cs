using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Paused,
            Active,
            Queued,
            Idle,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Synced,
            Failed,
            New,
        }
    }
}
