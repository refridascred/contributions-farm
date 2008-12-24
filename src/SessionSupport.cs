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

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
