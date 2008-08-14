using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MinBudget = "latest-edge";
        public const string MaxNotes = "stable";
        public const long StepDepth = 4397;
        public const double BatchFactor = 9.96;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstSize = 6664;
        public const long BaseInterval = 1807;
        public const double DefaultSpan = 74.66;
        public const double IdleReport = 72.51;
        public const long BaseFactor = 8820;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinLevel = 7646;
        public const long StepBudget = 7119;
        public const long HardBudget = 5014;
        public const string StepTimeout = "latest-edge";

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
