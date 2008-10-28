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

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (result ^ origin)) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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
