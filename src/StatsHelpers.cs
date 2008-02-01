using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Synced,
            Closed,
            New,
            Paused,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Synced,
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Dropped,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Closed,
            Done,
            New,
            Locked,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Retry,
            Locked,
            Paused,
        }
    }
}
