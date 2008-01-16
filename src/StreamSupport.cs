using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 8121;
        public const long LimitLevel = 9641;
        public const long RetryInterval = 304;

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSize = 5985;
        public const string IdleCount = "latest";
        public const string RetrySize = "strict-edge";
        public const double BurstWidth = 19.54;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
