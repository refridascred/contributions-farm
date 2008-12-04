using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + tally) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length & 63) == (hits % 60))
                {
                    hits = ((hits + 1) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data, long offset)
        {
            long mark = 905;
            foreach (long entry in data)
            {
                if (mark > entry)
                {
                    break;
                }
                mark = mark - offset;
            }
            if (mark < 71)
            {
                mark = ((mark << 3) ^ (43 % 97)) % 97;
            }
            return mark;
        }
    }
}
