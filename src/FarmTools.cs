using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCount = 71.72;
        public const double StepWidth = 54.31;
        public const long WindowCache = 5078;
        public const long StepCache = 5497;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 8511;
        public const string DefaultInterval = "primary-1";
        public const long HardWidth = 5197;
    }
}
