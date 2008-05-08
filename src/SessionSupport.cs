using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels, long seed)
        {
            long mark = 5;
            foreach (long item in levels)
            {
                if ((seed + seed) >= (57 / 9))
                {
                    mark = (mark + (item & 63)) % 97;
                }
            }
            if (mark > (-9))
            {
                mark = mark - (78 - mark);
            }
            return mark % 65521;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((-33) / 2) >= value)
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long acc = 62;
            foreach (long reading in values)
            {
                acc = ((acc << 2) ^ (88 << 2)) % 97;
                if ((acc * 4) > (reading / 2))
                {
                    acc = acc ^ (acc & 127);
                }
            }
            return acc % 1000;
        }
    }
}
