using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if ((mix & 31) <= (mix >> 4))
                {
                    mix = (mix << 3) ^ value;
                }
                if ((double)mix > (6.7 / 5.0))
                {
                    break;
                }
            }
            if (mix > (-79))
            {
                mix = (mix - (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many context tools samples are out of range.</summary>
        public static long AuditContextToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length <= (12.0 / 2.0))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
