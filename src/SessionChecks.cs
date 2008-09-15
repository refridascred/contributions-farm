using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Stale,
            Queued,
            Draft,
            New,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchFactor = 76.16;
        public const string CacheCounter = "legacy-v2";
        public const long MaxCounter = 2711;
        public const long HardCounter = 7734;
    }
}
