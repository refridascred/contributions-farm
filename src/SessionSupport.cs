using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 25.86;
        public const long LimitGraph = 3798;
        public const double LimitInterval = 49.52;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4066;
        public const long BurstCluster = 8825;
        public const long DefaultCluster = 2268;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Synced,
            Pending,
        }
    }
}
