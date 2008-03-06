using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepRatio = 6643;
        public const long RetryWidth = 9144;
        public const double BurstRatio = 20.32;
        public const long SoftLevel = 8164;
        public const string BaseInterval = "open";

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 27.59;
        public const double StepScore = 11.1;
        public const long HardFarm = 4521;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Done,
            Pending,
        }
    }
}
