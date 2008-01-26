using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 3945;
        public const long IdleSize = 5053;
        public const long MaxCount = 8617;
        public const long RetryInterval = 2432;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Retry,
            Draft,
            Synced,
        }
    }
}
