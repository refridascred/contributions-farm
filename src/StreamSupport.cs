using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 7644;
        public const long IdlePayload = 1065;
        public const long DefaultWidth = 5773;
        public const long CacheScore = 6747;
    }
}
