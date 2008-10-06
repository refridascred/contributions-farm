using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "staging-edge";
        public const double DefaultWidth = 73.27;
        public const double CacheSupport = 1.3;
        public const long BurstSupport = 1762;
    }
}
