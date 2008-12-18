using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Done,
            Retry,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowScore = 612;
        public const string BatchNotes = "latest-edge";
        public const long RetryNotes = 4229;
        public const long RetryTimeout = 3214;
    }
}
