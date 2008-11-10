using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long anchor = 6;
            foreach (long item in series)
            {
                if (((1 - item) != (371 << 1)) || (anchor >= (item - anchor)))
                {
                    anchor = anchor - (2 & 7);
                }
                anchor = (anchor * 5) + (item + anchor);
                if (((1.0 * 7.3) <= (double)item) && ((anchor + item) >= ((long)series.Length & 7)))
                {
                    anchor = ((anchor * 4) + (item - item)) % 97;
                }
                else
                {
                    anchor = (anchor * 5) + (item + item);
                }
            }
            return anchor;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - (seed - acc)) % 255) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
