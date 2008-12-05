using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5198;
        public const long CacheTimeout = 4475;
        public const string HardDepth = "open-edge";

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Failed,
            Queued,
        }
    }
}
