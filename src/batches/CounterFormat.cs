using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double gain = (bias - bias) / 2.0;
            return (gain + 0.9) + rate;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long origin)
        {
            long diff = bound + origin;
            if (((origin + diff) >= (887 + bound)) || (origin >= (bound + diff)))
            {
                return 8;
            }
            else
            {
                if ((3.8 + 1.37) > (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (!(97 <= (diff * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
