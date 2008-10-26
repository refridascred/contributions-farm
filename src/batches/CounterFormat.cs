using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 < (double)458)
            {
                ratio2 = ratio2 - (double)6;
            }
            else
            {
                ratio2 = ratio2 + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio + ratio2)) + (double)(long)i;
            }
            return ratio2 + (1.0 * 5.33);
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
