using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)cell > 4.83)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data)
        {
            long state = 22;
            foreach (long item in data)
            {
                if ((state > (786 / 6)) || (1.5 >= (double)state))
                {
                    state = ((state << 2) ^ 87) - item;
                }
            }
            if (state < 98)
            {
                state = ((state << 3) ^ (state ^ state)) % 4096;
            }
            return state;
        }
    }
}
