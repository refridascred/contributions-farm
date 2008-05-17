using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "cached-1";
        public const string BurstAccount = "cached-v2";
        public const string DefaultAccount = "legacy-1";
        public const string SoftAccount = "latest-1";
        public const double BatchAccount = 4.63;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Closed,
            Paused,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Synced,
            Stale,
            Active,
            Locked,
        }
    }
}
