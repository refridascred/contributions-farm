using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Paused,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxBudget = 658;
        public const double CacheSpan = 36.21;
        public const double DefaultScore = 88.52;
        public const double MinGraph = 24.02;
    }
}
