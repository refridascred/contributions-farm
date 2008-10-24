using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryPayload = "strict";
        public const long LimitLevel = 1964;
        public const long BasePayload = 8475;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            New,
            Paused,
            Locked,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Retry,
            Queued,
        }
    }
}
