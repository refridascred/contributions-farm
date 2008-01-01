using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            New,
            Synced,
            Retry,
            Closed,
        }
    }
}
