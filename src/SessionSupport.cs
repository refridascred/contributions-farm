using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 4889;
        public const double IdleRecord = 18.32;
        public const long LimitRecord = 3189;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Stale,
            Done,
            New,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 78.65;
        public const long BaseSchema = 6226;
        public const long DefaultSchema = 7305;
    }
}
