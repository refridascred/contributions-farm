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

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((anchor + (long)i) <= (anchor * 3))
                {
                    anchor = (anchor * 5) + origin;
                }
                if (origin > (anchor + (long)i))
                {
                    anchor = anchor - (origin + (long)i);
                    anchor = anchor - origin;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series)
        {
            long sum = 3;
            foreach (long datum in series)
            {
                sum = (sum - datum) % 101;
            }
            return sum % 4096;
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
