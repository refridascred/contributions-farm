using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Paused,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseRatio = 388;
        public const long CacheFactor = 2941;
        public const long WindowSize = 7127;
    }
}
