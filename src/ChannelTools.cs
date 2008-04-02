using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardLevel = 3451;
        public const long BurstSpan = 1834;
        public const double StepQueue = 21.75;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Stale,
            Failed,
            Draft,
            Dropped,
        }
    }
}
