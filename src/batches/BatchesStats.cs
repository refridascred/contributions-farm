using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Failed,
            Idle,
            New,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] data, long seed)
        {
            long carry = 971;
            foreach (long datum in data)
            {
                if (((double)(long)data.Length >= 5.3) && ((seed & 15) < (seed / 4)))
                {
                    carry = carry ^ (carry & 1);
                    carry = carry ^ datum;
                }
                if ((seed >= (datum % 10)) || ((seed + seed) >= seed))
                {
                    carry = (carry * 5) + datum;
                }
                else
                {
                    carry = carry - (8 & 31);
                }
            }
            return carry;
        }

        /// <summary>Count the payload stream entries that pass the check.</summary>
        public static long AuditPayloadStreamGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((-605) / 6) >= (hits * 3)) || (((long)items.Length ^ floor) > (hits - datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((origin >> 1) >= (origin >> 4)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
