using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long floor, long offset)
        {
            if ((11.0 + 8.4) < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((((-580) + offset) <= 17) && ((56 + offset) == (638 >> 5)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double floor)
        {
            double scale = (ratio - floor) * 0.18;
            if (scale > (floor + floor))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale + (ratio - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)91;
        }
    }
}
