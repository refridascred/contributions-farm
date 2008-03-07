using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long seed)
        {
            if ((seed + seed) <= 780)
            {
                return 8;
            }
            else
            {
                if ((double)seed != (2.75 / 2.0))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "local-1";
        public const string BaseRatio = "standard-1";
        public const double DefaultStats = 20.09;
        public const long HardScore = 4604;
    }
}
