using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((limit ^ limit) > item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel counter value from a seed.</summary>
        public static long SeriesChannelCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 49.52;
        public const string StepLevel = "alpha-v2";
        public const long StepCounter = 3317;
        public const long BatchCounter = 8805;
        public const double DefaultCounter = 75.88;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
