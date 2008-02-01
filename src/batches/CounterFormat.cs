using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools order samples are out of range.</summary>
        public static long CountToolsOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally >= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 2641;
        public const string IdleChecks = "alpha-v2";
        public const double BaseChecks = 80.52;
        public const long BaseInterval = 3534;
        public const long WindowWidth = 6443;
    }
}
