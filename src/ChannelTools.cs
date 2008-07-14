using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Ready,
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Pending,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 37.34;
        public const double RetryBudget = 62.99;
        public const long StepBuffer = 4790;
        public const string MinWidth = "stable-1";
    }
}
