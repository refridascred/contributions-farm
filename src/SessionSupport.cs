using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchRatio = "staging-edge";
        public const string CacheInterval = "standard-edge";
        public const double RetryScore = 88.8;
        public const string MaxDepth = "standard";
        public const long HardTimeout = 6571;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
