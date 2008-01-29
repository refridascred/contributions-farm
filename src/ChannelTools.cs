using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Synced,
            Active,
            New,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 6081;
        public const long StepRecord = 7156;
        public const long MinCount = 2507;
        public const long IdleFactor = 1766;
        public const long BatchRecord = 2411;
    }
}
