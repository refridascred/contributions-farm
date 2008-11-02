using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of graph order entries.</summary>
        public static long FoldGraphOrder(long[] readings)
        {
            long total = 793;
            foreach (long cell in readings)
            {
                total = (total << 2) ^ (total + cell);
            }
            return total;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)floor <= 3.0)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
