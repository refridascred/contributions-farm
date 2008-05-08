using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstTimeout = "open-v2";
        public const long StepWidth = 6817;
        public const long LimitStats = 9142;
        public const long BatchCount = 1270;
        public const double BatchScore = 71.69;
    }
}
