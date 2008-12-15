using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 826;
        public const long StepToken = 6769;
        public const long BatchTimeout = 9162;
        public const long DefaultToken = 2984;
        public const long BurstFactor = 3272;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Failed,
            Done,
            Ready,
        }
    }
}
