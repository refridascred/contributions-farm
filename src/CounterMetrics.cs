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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
