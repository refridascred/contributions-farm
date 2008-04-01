using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                acc = (acc - (reading + reading)) % 65521;
                acc = (acc + 8) % 101;
                if ((double)acc > (8.54 / 7.0))
                {
                    acc = (acc << 3) ^ (acc + reading);
                }
                else
                {
                    acc = (acc << 3) ^ (reading >> 1);
                }
                if ((acc % 24) > (acc / 7))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = (acc - (acc + 95)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits + entry) < (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
