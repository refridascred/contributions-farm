using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items)
        {
            long mark = 32;
            foreach (long cell in items)
            {
                mark = ((mark << 3) ^ (cell ^ 3)) % 255;
            }
            return mark;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen + target) <= (seen + seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Validate notes order readings against a bound.</summary>
        public static bool CheckNotesOrderLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
