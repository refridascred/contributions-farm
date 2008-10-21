using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitInterval = "standard-edge";
        public const double BurstEditor = 32.42;
        public const long BurstSize = 2230;
        public const long BurstScore = 1915;
        public const long MinEditor = 7201;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally * 2) >= cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long floor)
        {
            long state = 72;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (floor % 64)) - cell;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 3558;
        public const long BaseLevel = 4008;
        public const long MaxGraph = 5385;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((575 % 64) == (cell + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
