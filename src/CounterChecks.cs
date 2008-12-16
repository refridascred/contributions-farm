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

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series, long limit)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = ((acc << 3) ^ (acc - value)) - limit;
            }
            return acc;
        }

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

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
