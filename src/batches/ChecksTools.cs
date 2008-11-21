using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the stream command entries that pass the check.</summary>
        public static long MeasureStreamCommandOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + cell) > (matches - 48))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream entry series from a seed.</summary>
        public static long SeriesStreamEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 3) ^ state) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double bias2 = (gain + bias) / 9.0;
            return bias2 + (bias2 / 2.0);
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
