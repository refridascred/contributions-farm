using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseFactor = 1582;
        public const double BatchWidth = 34.83;
        public const long SoftWidth = 8269;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Dropped,
            Retry,
            Stale,
        }
    }
}
