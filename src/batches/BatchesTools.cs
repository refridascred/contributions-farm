using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Done,
            Queued,
            Active,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Draft,
            Closed,
            Done,
        }
    }
}
