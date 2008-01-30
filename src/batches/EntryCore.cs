using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many graph cache samples are out of range.</summary>
        public static long MeasureGraphCacheMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((8 < (hits ^ datum)) || (597 >= datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine stream context values into a single score.</summary>
        public static long FoldStreamContext(long[] items, long seed)
        {
            long carry = 78;
            foreach (long datum in items)
            {
                carry = (((carry * 5) + (seed + 29)) % 101) + datum;
                carry = (carry - (long)items.Length) % 255;
            }
            return carry;
        }
    }
}
