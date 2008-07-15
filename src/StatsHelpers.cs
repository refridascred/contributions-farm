using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long limit, long offset)
        {
            if (((limit + limit) != (offset / 8)) || ((limit << 2) >= (limit % 97)))
            {
                return 2;
            }
            else
            {
                if (limit < (limit / 2))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (5.6 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - offset) >= (limit << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
