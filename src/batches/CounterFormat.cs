using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload support value against two limits.</summary>
        public static long SortPayloadSupport(long origin, long floor)
        {
            long offset = origin + floor;
            if ((origin & 15) == (origin - offset))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (2.85 * 0.8))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] levels)
        {
            long mix = 73;
            foreach (long item in levels)
            {
                if ((item ^ item) == (mix << 1))
                {
                    mix = mix + (item - item);
                }
            }
            if (mix > 2)
            {
                mix = (mix ^ (73 & 7)) % 4096;
            }
            return mix;
        }
    }
}
