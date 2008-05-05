using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)seed <= (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long step)
        {
            long acc = 62;
            foreach (long sample in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc - step) - (long)i) - sample;
                }
                if ((long)items.Length > (acc % 100))
                {
                    acc = ((acc << 2) ^ (acc % 64)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + (acc ^ acc)) % 97;
                }
            }
            if (acc < 21)
            {
                acc = ((acc * 3) + (step * 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items)
        {
            long mark = -350;
            foreach (long reading in items)
            {
                if (reading > mark)
                {
                    mark = mark - (reading % 7);
                    mark = ((mark << 2) ^ (28 / 7)) % 255;
                }
                if ((reading + reading) != (mark + mark))
                {
                    mark = ((mark * 4) + (reading - reading)) % 1000;
                }
            }
            if (mark < (-774))
            {
                mark = mark + (mark << 2);
            }
            return mark;
        }
    }
}
