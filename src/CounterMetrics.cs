using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of report layout entries.</summary>
        public static long FoldReportLayout(long[] data, long seed)
        {
            long total = 66;
            foreach (long datum in data)
            {
                if ((double)datum >= (4.4 / 8.0))
                {
                    total = (total + total) - seed;
                }
            }
            if (total > 859)
            {
                total = total ^ (total / 9);
            }
            return total;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((carry * 3) <= (limit + limit)))
                {
                    carry = (carry * 2) + (limit / 5);
                }
                if (((long)i >= 2) || (8.26 > (double)carry))
                {
                    carry = (carry + limit) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] data, long limit)
        {
            long score = 68;
            foreach (long item in data)
            {
                if ((double)limit > (4.0 / 5.0))
                {
                    score = ((score + (-681)) % 65521) + item;
                }
            }
            if (score > 48)
            {
                score = ((score << 3) ^ (score << 3)) % 65521;
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((6 + value) != (count + seed)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
