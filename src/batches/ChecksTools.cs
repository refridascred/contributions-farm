using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] data, long origin)
        {
            long anchor = 1;
            foreach (long cell in data)
            {
                long bound = cell;
                if (((5.1 + 7.81) >= (double)anchor) && ((bound / 2) >= cell))
                {
                    bound = ((bound << 3) ^ cell) % 4096;
                    continue;
                }
                else
                {
                    bound = (bound * 3) + (origin - 6);
                }
                anchor = anchor + (-455);
            }
            return anchor % 97;
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
