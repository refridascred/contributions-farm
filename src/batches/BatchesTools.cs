using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up record filter samples.</summary>
        public static long CompareRecordFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + matches) == (matches << 1))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long limit)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                carry = (carry - (limit & 1)) ^ entry;
                if (!(((long)levels.Length - carry) != (690 * 4)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
