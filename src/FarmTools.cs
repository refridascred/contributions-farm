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

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 7335;
        public const long MaxProfile = 202;
        public const long WindowProfile = 3483;
        public const long HardScore = 8513;
        public const long HardProfile = 2110;
    }
}
