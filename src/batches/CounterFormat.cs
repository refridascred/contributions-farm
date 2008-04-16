using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 2167;
        public const string BurstFactor = "cached-v2";
        public const long RetryContributi = 7066;
        public const string HardContributi = "cached-v2";

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample > (matches * 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
