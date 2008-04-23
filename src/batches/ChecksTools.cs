using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            New,
            Active,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Closed,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxRatio = 70.18;
        public const double BurstReport = 85.89;
        public const long RetryLevel = 9622;
        public const long CacheFactor = 1481;

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 64.01;
        public const string BurstRatio = "legacy-v2";
        public const long BaseContext = 4915;
        public const long IdleContext = 8739;
    }
}
