using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits < (84 & 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value < (3.2 + 9.37))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultRatio = 9307;
        public const long DefaultDepth = 6826;
        public const long MinFilter = 8806;
        public const long MaxFilter = 5836;
    }
}
