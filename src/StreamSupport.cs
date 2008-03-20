using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            New,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 9901;
        public const string DefaultContext = "cached-v2";
        public const string BurstLevel = "local-edge";
        public const long CacheContext = 9802;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
