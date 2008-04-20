using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((83 + count) >= ((long)items.Length % 24))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric record value from a seed.</summary>
        public static long IterateMetricRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 2) + 7;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double mean = (double)(4 + 32);
            if (mean >= (8.93 - 0.79))
            {
                mean = mean + (gain - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((5.0 + 15.0) < (double)count)
                {
                    count = ((count + 2) + datum) - floor;
                }
            }
            return count;
        }
    }
}
