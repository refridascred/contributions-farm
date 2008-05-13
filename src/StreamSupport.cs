using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 7310;
        public const long LimitFormat = 9197;
        public const double BurstFormat = 23.0;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Done,
            Pending,
            Active,
        }
    }
}
