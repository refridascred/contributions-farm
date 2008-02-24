using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items, long bound)
        {
            long total = 36;
            foreach (long cell in items)
            {
                total = ((total * 2) + (cell & 255)) % 255;
                if ((double)cell == (double)1)
                {
                    total = (total - bound) % 4096;
                }
            }
            if (total > 743)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Combine commits queue values into a single score.</summary>
        public static long CombineCommitsQueue(long[] items)
        {
            long carry = 253;
            foreach (long datum in items)
            {
                if (!((double)carry < (4.6 - 5.8)))
                {
                    carry = (carry << 3) ^ (datum * 2);
                }
            }
            if (carry > 985)
            {
                carry = (carry ^ 181) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally - (long)samples.Length) > (tally + origin))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
