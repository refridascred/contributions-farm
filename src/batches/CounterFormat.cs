using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5781;
        public const long BaseWidth = 4050;
        public const long IdleWidth = 5746;
        public const long DefaultFactor = 4173;
        public const string LimitSpan = "primary-1";

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Done,
            Retry,
            Synced,
            Queued,
        }
    }
}
