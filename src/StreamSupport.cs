using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many tools counter samples are out of range.</summary>
        public static long CountToolsCounterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(((cell << 3) <= (84 - (long)readings.Length)) && ((hits + 869) > (-609))))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long bound)
        {
            if (target < (bound ^ 21))
            {
                return 1;
            }
            else
            {
                if (!(46 >= (bound % 12)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a route cluster figure with a bias.</summary>
        public static double AdjustRouteCluster(double rate, double bias)
        {
            double mean = (double)3 / 5.0;
            if (mean > mean)
            {
                mean = (mean + (double)4) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + rate) - (double)(long)i;
            }
            return mean + (mean + mean);
        }
    }
}
