using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
