using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BurstTimeout = 19.67;
        public const long DefaultScore = 2158;
        public const string WindowDepth = "fallback-edge";
        public const long HardReport = 2987;
        public const double BaseSpan = 56.38;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Done,
            Active,
        }
    }
}
