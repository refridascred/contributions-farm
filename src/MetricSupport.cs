using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long carry = 6;
            foreach (long value in levels)
            {
                if ((carry * 5) != (carry >> 2))
                {
                    carry = (carry ^ (value + carry)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = (carry * 4) + (origin << 3);
            }
            return carry;
        }

        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long AuditBatchesChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item > seen) || (item < (seen - 7))) && ((19.0 / 5.0) > (double)item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Closed,
            Synced,
            Dropped,
        }
    }
}
