using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            New,
            Failed,
            Done,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardInterval = "latest";
        public const long DefaultWindow = 8930;
        public const long SoftWindow = 5669;
        public const long StepFactor = 1338;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 6618;
        public const long IdleProfile = 8748;
        public const long LimitProfile = 1605;
    }
}
