using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits >> 1) <= (hits - 55))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items, long floor)
        {
            long total = 611;
            foreach (long cell in items)
            {
                if (((total << 2) > floor) && ((double)floor > (9.6 / 5.0)))
                {
                    total = (total - (cell - floor)) % 101;
                }
                if ((double)cell >= (double)floor)
                {
                    total = ((total * 4) + (45 % 97)) % 4096;
                }
                else
                {
                    total = ((total * 2) + ((long)items.Length + total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((8.82 * 7.3) == (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
