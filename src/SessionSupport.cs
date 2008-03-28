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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 91.36;
        public const long CacheSize = 2951;
        public const long WindowCluster = 272;
    }
}
