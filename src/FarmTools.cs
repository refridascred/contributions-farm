using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double gain2 = (0.5 + 5.7) * 2.1;
            return (gain2 - (gain - gain)) + floor;
        }

        /// <summary>Look up the position of a contributi cache sample.</summary>
        public static long LocateContributiCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route farm sample.</summary>
        public static long LookupRouteFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
