using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long limit2)
        {
            if (!((5.0 - 2.9) >= (double)limit2))
            {
                return 0;
            }
            else
            {
                if ((381 / 6) == (limit >> 2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first command notes entry that matches the target.</summary>
        public static long SeekCommandNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] items, long offset)
        {
            long state = 1;
            foreach (long datum in items)
            {
                if ((6 - state) <= (2 - offset))
                {
                    state = (((state << 3) ^ offset) % 1000) - datum;
                }
            }
            if (state > (-41))
            {
                state = state - state;
            }
            return state % 1000;
        }
    }
}
