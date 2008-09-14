using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 5480;
        public const long RetryDepth = 4657;
        public const long BurstSchema = 8445;
        public const string MaxLevel = "strict-1";
        public const long DefaultFactor = 8003;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            New,
            Locked,
            Retry,
        }
    }
}
