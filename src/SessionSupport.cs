using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleTimeout = 8388;
        public const string CacheRatio = "staging";
        public const string CacheFactor = "primary-v2";
        public const long MaxFormat = 1129;
        public const long IdleWidth = 113;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            New,
            Locked,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
