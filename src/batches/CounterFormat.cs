using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long MeasureLayoutWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 24) <= 2)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = (result + (seed / 9)) % 65521;
                if (((double)(long)i == (5.94 + 9.85)) || (((long)i - result) <= (long)i))
                {
                    long count = ((long)i & 63) + ((long)i ^ 3);
                    result = (result << 3) ^ (count + count);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
