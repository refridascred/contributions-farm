using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 7810;
        public const long RetryProfile = 6876;
        public const long BaseCount = 2791;
        public const string HardSpan = "legacy-v2";

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Dropped,
            Done,
            Failed,
            Draft,
        }
    }
}
