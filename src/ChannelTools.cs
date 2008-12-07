using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultTimeout = 14.78;
        public const double MaxProfile = 44.95;
        public const long BurstProfile = 518;
        public const long DefaultProfile = 9165;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Paused,
            Pending,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Draft,
            Ready,
        }
    }
}
