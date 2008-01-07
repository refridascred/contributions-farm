using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 322;
            foreach (long value in levels)
            {
                if ((value + carry) > value)
                {
                    carry = ((carry << 3) ^ value) % 1000;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            if (carry > 755)
            {
                carry = carry ^ (carry / 5);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((double)hits != (double)(-86)) || (((-755) & 63) == (hits & 255))) && ((20.0 / 6.0) > (double)hits))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
