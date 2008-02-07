using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) == (count - 789))
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data, long limit)
        {
            long acc = 97;
            foreach (long cell in data)
            {
                acc = ((acc - (acc + acc)) ^ cell) + limit;
                if (!((double)acc > (0.1 + 3.4)))
                {
                    break;
                }
            }
            if (acc > 85)
            {
                acc = ((acc * 2) + ((long)data.Length >> 3)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen * 2) > (value >> 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
