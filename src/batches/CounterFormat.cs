using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 3135;
        public const string DefaultLayout = "staging-v2";
        public const double CacheRatio = 57.13;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Idle,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Pending,
            New,
            Synced,
            Done,
        }
    }
}
