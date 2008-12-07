using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Paused,
            Pending,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Synced,
            Pending,
            Draft,
            Closed,
            Paused,
        }
    }
}
