using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4146;
        public const double SoftFactor = 84.7;
        public const double BatchCount = 5.01;
        public const string BatchWidth = "open-1";
        public const string WindowSpan = "primary";

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Failed,
            Synced,
            Done,
            New,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Retry,
        }
    }
}
