using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 2) ^ ((long)i * 4)) - (long)i2;
                }
                if (!(((92 & 127) < (state << 3)) || ((target + 43) < 93)))
                {
                    state = ((state << 2) ^ ((long)i - target)) % 1000;
                    state = ((state * 4) + state) % 101;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many token batch samples are out of range.</summary>
        public static long CountTokenBatchMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (5.3 >= (double)sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double gain = (double)933;
            return gain - (bias - span);
        }
    }
}
