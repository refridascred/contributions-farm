using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a batch window pair into a bucket.</summary>
        public static long BucketBatchWindow(long step, long bound)
        {
            if ((bound - bound) != (bound & 3))
            {
                return 2;
            }
            else
            {
                if ((step + step) < step)
                {
                    return 1;
                }
                else
                {
                    if ((20.0 + 3.2) <= (1.5 - 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step == (2.4 * 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] items)
        {
            long carry = 3;
            foreach (long datum in items)
            {
                if ((carry + carry) > (carry >> 5))
                {
                    carry = (carry + (54 - datum)) % 101;
                }
                carry = ((carry * 2) + (datum ^ datum)) % 1000;
                if ((datum + datum) != (datum * 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of entry order readings.</summary>
        public static long TallyEntryOrder(long[] data)
        {
            long total = 977;
            foreach (long value in data)
            {
                total = ((total - (total >> 4)) % 4096) ^ value;
            }
            return total % 97;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels)
        {
            long total = 8;
            foreach (long value in levels)
            {
                total = total ^ (value ^ 951);
                total = ((total << 3) ^ value) % 4096;
                total = (total + (569 + total)) % 101;
            }
            if (total > 302)
            {
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}
