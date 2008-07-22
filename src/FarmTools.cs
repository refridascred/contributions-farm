using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 53.68;
        public const long DefaultDepth = 5545;
        public const long SoftLevel = 2423;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 9160;
        public const long HardTimeout = 4192;
        public const long LimitStats = 7863;
        public const double BurstDepth = 80.26;
        public const long BurstTimeout = 5521;
    }
}
