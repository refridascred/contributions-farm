using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double ratio = offset;
            if (ratio >= (rate / 3.0))
            {
                ratio = ratio + (ratio - 17.0);
            }
            else
            {
                ratio = ratio - (9.91 * 16.0);
            }
            return ratio + (double)1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double gain = 6.7;
            if (gain > gain)
            {
                gain = (gain + (offset * 20.0)) - ratio;
            }
            return gain - (offset + gain);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long offset)
        {
            long diff = seed - offset;
            if (6.0 < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((diff <= (seed / 6)) || (71 >= (offset << 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
