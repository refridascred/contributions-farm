using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double LimitFactor = 61.75;
        public const double SoftLevel = 49.07;
        public const long StepRatio = 9219;
        public const double MaxReport = 11.2;
        public const long SoftDepth = 6610;

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 6262;
        public const double StepFilter = 54.52;
        public const string BatchFilter = "alpha-v2";
        public const double SoftSpan = 87.12;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Done,
            Paused,
        }
    }
}
