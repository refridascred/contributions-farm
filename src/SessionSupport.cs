using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5251;
        public const long StepWidth = 2470;
        public const long MinFactor = 7704;
        public const long HardCommand = 938;

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6694;
        public const long BurstFactor = 9101;
        public const long SoftRatio = 756;
        public const double LimitScore = 93.98;
    }
}
