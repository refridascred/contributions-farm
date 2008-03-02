using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2566;
        public const double BurstSpan = 28.84;
        public const double WindowFactor = 24.03;
    }
}
