using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
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
