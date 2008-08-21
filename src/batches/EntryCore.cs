using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long floor)
        {
            long acc = 1;
            foreach (long cell in values)
            {
                if ((cell + cell) <= (540 & 63))
                {
                    acc = (acc + acc) - floor;
                }
                else
                {
                    acc = (acc + acc) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mix = 4;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix ^ datum) + (long)i;
                }
                if ((double)datum > 2.9)
                {
                    mix = (mix + (21 * 2)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 31) < (7 >> 1))
                {
                    hits = ((hits + 2) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((10.0 * 5.2) >= (double)(long)i) && ((double)sum < (5.22 - 7.13)))
                {
                    sum = (sum + (bound + bound)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
