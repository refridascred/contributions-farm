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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepDepth = 26.68;
        public const string MaxRatio = "strict-edge";
        public const long WindowWidth = 635;
        public const long CacheLevel = 3402;
        public const string BaseMetrics = "primary-1";

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
