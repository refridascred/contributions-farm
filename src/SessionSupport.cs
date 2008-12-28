using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5330;
        public const long MinBatch = 5387;
        public const long BaseSize = 1715;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
