using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples, long bound)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                if (1.0 < (double)item)
                {
                    mark = mark ^ (bound - bound);
                }
            }
            if (mark > 91)
            {
                mark = (mark - (83 + mark)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((8 + reading) <= (37 << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
