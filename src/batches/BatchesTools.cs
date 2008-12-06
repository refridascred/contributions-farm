using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit schema stream readings against a rule.</summary>
        public static long AuditSchemaStreamGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum >> 4) > (367 / 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long bound2)
        {
            if (((bound * 5) >= (bound + bound)) && (3 >= (bound % 2)))
            {
                return 1;
            }
            else
            {
                if (bound >= (bound + 98))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples, long seed)
        {
            long acc = 87;
            foreach (long sample in samples)
            {
                acc = ((acc * 2) + (sample >> 1)) + seed;
            }
            return acc;
        }
    }
}
