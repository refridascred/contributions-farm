using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                if (anchor >= bound)
                {
                    anchor = anchor - (6 + anchor);
                }
                anchor = (anchor * 3) + ((long)i << 2);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
