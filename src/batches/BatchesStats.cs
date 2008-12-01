using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long carry = 9;
            foreach (long value in items)
            {
                long tally = (7 ^ carry) - (value >> 2);
                carry = carry - (tally % 64);
                if ((51 & 7) < carry)
                {
                    carry = (carry + (long)items.Length) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((limit - datum) <= (limit + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long anchor = -997;
            foreach (long entry in readings)
            {
                anchor = (anchor + (683 + anchor)) - entry;
            }
            return anchor;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            New,
            Stale,
            Draft,
        }
    }
}
