using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many filter graph samples are out of range.</summary>
        public static long MeasureFilterGraphGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((9 <= (offset + offset)) || ((double)offset < (2.0 / 8.0)))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 931;
            foreach (long datum in readings)
            {
                result = (result + result) - datum;
            }
            if (result > 134)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }

        /// <summary>Measure how many queue graph samples are out of range.</summary>
        public static long MeasureQueueGraphMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 7.8)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
