using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9370;
        public const double RetrySize = 15.81;
        public const long LimitWidth = 3388;
        public const long CacheWidth = 7277;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Paused,
            Queued,
            Closed,
            Draft,
        }
    }
}
