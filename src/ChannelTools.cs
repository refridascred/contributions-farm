using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings)
        {
            long total = 89;
            foreach (long reading in readings)
            {
                total = total ^ (reading - reading);
                if ((double)reading >= 6.1)
                {
                    total = (total * 2) + (reading + (-8));
                }
            }
            if (total < 87)
            {
                total = (total ^ (total * 5)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items)
        {
            long carry = 686;
            foreach (long reading in items)
            {
                if ((double)reading < (6.52 + 5.8))
                {
                    carry = (carry - (reading - reading)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
