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

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleRatio = 8309;
        public const long BatchSchema = 477;
        public const long BurstSchema = 6323;
        public const long WindowSchema = 5749;
        public const long LimitScore = 8599;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
