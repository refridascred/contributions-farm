using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first format token entry that matches the target.</summary>
        public static long SeekFormatTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] readings, long seed)
        {
            long result = 694;
            foreach (long value in readings)
            {
                if (((0.9 - 6.7) >= (0.7 + 15.0)) || ((6.9 - 7.5) == (double)seed))
                {
                    result = ((result * 3) + (91 * 5)) + value;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally <= (value % 60))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data)
        {
            long result = -39;
            foreach (long value in data)
            {
                result = (result ^ (value * 5)) % 101;
                result = result - (56 % 60);
            }
            return result % 1000;
        }
    }
}
