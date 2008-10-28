using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Queued,
            Retry,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6264;
        public const string RetryProfile = "primary-v2";
        public const long StepSpan = 1731;
        public const double DefaultProfile = 41.24;
    }
}
