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

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftCount = "staging-1";
        public const double CacheRatio = 78.81;
        public const string MinCount = "staging-1";

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
