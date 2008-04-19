using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of batch checks readings.</summary>
        public static long CompareBatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            Locked,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long origin)
        {
            long carry = -90;
            foreach (long cell in values)
            {
                if (2.27 < (double)cell)
                {
                    carry = ((carry << 3) ^ (carry * 3)) % 4096;
                }
                else
                {
                    carry = (carry - (origin ^ cell)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (1.0 <= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
