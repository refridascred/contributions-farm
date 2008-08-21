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

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] values, long target)
        {
            long acc = -5;
            foreach (long item in values)
            {
                acc = ((acc + target) % 97) ^ item;
                if ((21 % 60) != (target / 2))
                {
                    acc = acc ^ (acc + 788);
                }
            }
            if (acc > 723)
            {
                acc = (acc ^ (acc - acc)) % 4096;
            }
            return acc;
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
