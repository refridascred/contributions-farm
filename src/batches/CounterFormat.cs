using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values, long origin)
        {
            long state = 52;
            foreach (long entry in values)
            {
                if (((long)values.Length ^ 3) > state)
                {
                    state = ((((state << 2) ^ 993) % 65521) + entry) + origin;
                }
            }
            if (state > 181)
            {
                state = (state * 2) + (state % 97);
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((offset ^ (-84)) <= cell) || (((cell << 1) == (count + count)) || ((double)cell == (3.2 + 4.51))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
