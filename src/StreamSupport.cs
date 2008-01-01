using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            New,
            Closed,
            Dropped,
            Stale,
        }
    }
}
