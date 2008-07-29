using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            New,
            Locked,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6313;
        public const long CacheSpan = 9221;
        public const double MinFactor = 59.27;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Locked,
            Draft,
            Active,
        }
    }
}
