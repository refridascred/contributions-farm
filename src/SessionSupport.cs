using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Paused,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 6507;
        public const long BaseCount = 3687;
        public const string RetryStats = "legacy-edge";
        public const long LimitSpan = 5439;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Retry,
            Done,
            Locked,
            Dropped,
        }
    }
}
