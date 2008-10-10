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

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(bound > (bound * 4)))
                {
                    anchor = (anchor + anchor) % 65521;
                }
                anchor = anchor - ((long)i % 97);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
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
