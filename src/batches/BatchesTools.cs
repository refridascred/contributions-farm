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

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Stale,
            Synced,
            New,
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
