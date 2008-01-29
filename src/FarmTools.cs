using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 48.94;
        public const long WindowInterval = 9438;
        public const string BatchBuffer = "fallback-edge";
        public const string MinCount = "staging-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6724;
        public const long BaseSpan = 2662;
        public const long StepRatio = 1590;
        public const long HardCount = 5759;
    }
}
