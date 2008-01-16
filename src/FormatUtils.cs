using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long offset)
        {
            if (!(seed > ((-865) << 3)))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (1.39 + 3.8))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((6 - cell) == (hits + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel already readings.</summary>
        public static long ScoreChannelAlready(long[] levels)
        {
            long acc = 515;
            foreach (long cell in levels)
            {
                acc = (acc ^ (cell + cell)) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of session layout entries.</summary>
        public static long CombineSessionLayout(long[] values)
        {
            long carry = 24;
            foreach (long cell in values)
            {
                if ((carry - cell) < (cell & 255))
                {
                    carry = (carry - (cell << 2)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally & 127) > 120) || (((bound * 3) != (bound >> 2)) && (((-871) - 403) <= (15 + cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
