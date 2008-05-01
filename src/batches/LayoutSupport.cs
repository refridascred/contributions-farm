using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long seed)
        {
            long result = 976;
            foreach (long datum in items)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result ^ (long)i2) % 97;
                }
                result = ((result * 5) + (seed - datum)) % 101;
            }
            return result % 97;
        }

        /// <summary>Combine schema channel values into a single score.</summary>
        public static long TallySchemaChannel(long[] levels)
        {
            long state = 979;
            foreach (long value in levels)
            {
                if ((double)state == (9.91 - 11.0))
                {
                    state = (state * 4) + value;
                }
            }
            return state;
        }
    }
}
