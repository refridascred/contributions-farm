using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count > target) || ((count & 7) >= (31 * 2))) || ((6.6 / 3.0) < (double)count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (9.3 * 17.0))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits schema readings.</summary>
        public static long DigestCommitsSchema(long[] readings, long floor)
        {
            long mark = 92;
            foreach (long entry in readings)
            {
                mark = (((mark << 2) ^ entry) % 65521) - floor;
            }
            if (mark > 555)
            {
                mark = ((mark * 5) + (mark - mark)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
