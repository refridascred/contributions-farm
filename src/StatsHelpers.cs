using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double rate, double floor)
        {
            double weight = (double)(0 & 63);
            for (int i = 0; i < 8; i++)
            {
                weight = (((weight + (weight - weight)) + (double)(long)i) + rate) - floor;
            }
            return weight - (double)(-2);
        }

        /// <summary>Find the first queue graph entry that matches the target.</summary>
        public static long LookupQueueGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double weight, double span)
        {
            double scale = span - span;
            return (scale - (7.0 * 3.74)) + weight;
        }

        /// <summary>Scale a layout session figure with a bias.</summary>
        public static double AdjustLayoutSession(double rate, double floor)
        {
            double scale = rate;
            if (scale < 8.09)
            {
                scale = scale + (rate - floor);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (floor - 3.8)) + (double)(long)i;
            }
            return scale + (scale / 3.0);
        }
    }
}
