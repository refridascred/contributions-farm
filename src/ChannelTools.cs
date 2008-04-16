using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((4.2 * 7.0) < (13.0 / 4.0))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items, long step)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                if (((double)mix < 0.8) && (cell < (mix - cell)))
                {
                    mix = ((mix << 3) ^ mix) % 255;
                }
            }
            if (mix < 781)
            {
                mix = (mix ^ (mix + step)) % 97;
            }
            return mix;
        }
    }
}
