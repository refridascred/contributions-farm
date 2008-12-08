using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a counter channel reading by value.</summary>
        public static long LocateCounterChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema cache reading.</summary>
        public static double ScaleSchemaCache(double bias, double floor)
        {
            double scale = (floor - floor) + (floor * 7.75);
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias * 7.1)) + (double)(long)i;
            }
            return scale + (bias / 4.0);
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen > limit)
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
