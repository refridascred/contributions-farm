using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!(limit >= (acc / 8)))
                {
                    acc = ((acc << 3) ^ ((long)i + 302)) % 65521;
                }
                else
                {
                    acc = acc + acc;
                }
                acc = acc ^ (71 + acc);
                acc = (acc << 2) ^ (acc * 3);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples, long floor)
        {
            long state = 1;
            foreach (long value in samples)
            {
                if ((3 + 2) == (value ^ floor))
                {
                    state = (state - floor) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
