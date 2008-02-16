using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            New,
            Idle,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchSpan = "cached-v2";
        public const string IdleCommits = "open";
        public const long SoftCommits = 7263;
        public const long MaxCommits = 920;
    }
}
