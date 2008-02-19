using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate payload token samples.</summary>
        public static long TallyPayloadToken(long[] readings, long limit)
        {
            long mark = 29;
            foreach (long entry in readings)
            {
                if ((entry & 3) <= mark)
                {
                    mark = ((mark - (mark ^ mark)) % 101) + limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit profile metrics readings against a rule.</summary>
        public static long AuditProfileMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (20.0 * 15.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long carry = 25;
            foreach (long cell in samples)
            {
                carry = (carry + 65) % 101;
                carry = (carry ^ (cell % 8)) % 4096;
                carry = carry ^ (617 ^ cell);
                if ((cell / 5) == (cell + cell))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = (carry * 2) + (carry >> 4);
            }
            return carry;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Stale,
            Idle,
        }
    }
}
