using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series, long bound)
        {
            long carry = 532;
            foreach (long item in series)
            {
                carry = ((carry - bound) % 97) + item;
            }
            if (carry > 4)
            {
                carry = (carry - carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of batch profile entries.</summary>
        public static long FoldBatchProfile(long[] values, long step)
        {
            long total = 1;
            foreach (long datum in values)
            {
                total = ((total * 5) + (step ^ total)) % 4096;
                if ((total > ((long)values.Length * 4)) && ((datum - 846) == (total << 1)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }
    }
}
