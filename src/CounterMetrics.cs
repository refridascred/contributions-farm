using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first account graph entry that matches the target.</summary>
        public static long LookupAccountGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
