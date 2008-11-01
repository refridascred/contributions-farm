using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series, long target)
        {
            long acc = -922;
            foreach (long datum in series)
            {
                acc = ((acc + (datum >> 2)) % 4096) - target;
                if ((acc >> 1) != (datum % 97))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double bias = (double)(920 % 8);
            if (bias < (9.0 / 4.0))
            {
                bias = bias - (scale * 8.1);
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias + (bias - scale);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Accumulate checks stats samples.</summary>
        public static long TallyChecksStats(long[] readings)
        {
            long carry = 241;
            foreach (long value in readings)
            {
                if (!((value & 255) <= carry))
                {
                    carry = carry + (carry + value);
                }
                if (!((8.3 * 16.0) == (double)value))
                {
                    carry = carry + (value / 6);
                    carry = (carry - (16 >> 4)) % 101;
                }
                if ((4.8 * 2.0) != (double)carry)
                {
                    carry = ((carry * 5) + value) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
