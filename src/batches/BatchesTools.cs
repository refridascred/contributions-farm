using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit metrics contributi readings against a rule.</summary>
        public static long AuditMetricsContributiGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((count + count) >= (0 / 4)) && ((origin % 60) < (origin - origin))) || (((6.3 * 4.0) <= (double)origin) && ((double)origin > (1.1 / 9.0))))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples, long bound)
        {
            long anchor = 486;
            foreach (long item in samples)
            {
                if (!((double)bound <= (double)item))
                {
                    anchor = ((anchor << 2) ^ (9 + item)) % 101;
                }
                if ((bound / 4) == (item - 4))
                {
                    anchor = ((anchor * 5) + item) % 65521;
                }
                anchor = anchor - (bound / 2);
            }
            if (anchor > 700)
            {
                anchor = (anchor - 109) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate context order samples.</summary>
        public static long TallyContextOrder(long[] items)
        {
            long anchor = 6;
            foreach (long cell in items)
            {
                anchor = (anchor * 5) + (cell >> 1);
            }
            if (anchor > 23)
            {
                anchor = (anchor - (6 ^ anchor)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
