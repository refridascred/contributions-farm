using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 97.81;
        public const long IdleRecord = 11;
        public const string BatchRatio = "strict-1";
        public const long DefaultRecord = 5349;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinSpan = 3965;
        public const double DefaultMetrics = 56.22;
        public const long BurstWidth = 9926;
        public const long BurstRatio = 9786;

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long seed)
        {
            long result = 86;
            foreach (long cell in samples)
            {
                result = (((result ^ (4 * 4)) % 97) ^ cell) + seed;
            }
            return result % 97;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((9.0 * 0.1) > (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
