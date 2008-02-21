using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((offset + 227) >= (offset2 - offset2))
            {
                return 0;
            }
            else
            {
                if (((offset2 & 7) != (offset + offset2)) && ((offset + 27) >= (6 + origin)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command batch measurements.</summary>
        public static double SmoothCommandBatch(double scale, double offset)
        {
            double load = (double)(790 - 88);
            if (load >= (load - offset))
            {
                load = load + (scale + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)6) - (double)(long)i;
            }
            return load - load;
        }
    }
}
