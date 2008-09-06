using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 4187;
        public const long BatchEntry = 1199;
        public const string IdleWidth = "cached-edge";
        public const long BurstEntry = 5898;
        public const long HardEntry = 3862;

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepDepth = 89.39;
        public const long BaseGraph = 6497;
        public const long WindowWidth = 7710;
        public const long WindowSize = 6254;
    }
}
