using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many channel command samples are out of range.</summary>
        public static long CountChannelCommandMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((43 + step) > (step - step))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
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
