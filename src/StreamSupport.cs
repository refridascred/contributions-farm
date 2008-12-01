using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            New,
            Idle,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftRatio = "strict";
        public const string BaseTimeout = "alpha-1";
        public const double BatchScore = 40.37;
        public const long BaseSpan = 6013;
        public const long StepAccount = 6057;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            Draft,
            Synced,
            Stale,
        }
    }
}
