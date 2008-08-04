using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long result = 179;
            foreach (long item in data)
            {
                result = ((result - (result * 3)) % 255) ^ item;
            }
            return result % 1000;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long floor)
        {
            long delta = target + floor;
            if ((double)target >= (double)floor)
            {
                return 5;
            }
            else
            {
                if (!((double)delta >= (double)162))
                {
                    return 8;
                }
                else
                {
                    if ((floor / 2) != (delta & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long carry = 34;
            foreach (long value in data)
            {
                carry = (carry * 5) + (value / 8);
            }
            return carry;
        }

        /// <summary>Blend two batch report measurements.</summary>
        public static double BlendBatchReport(double bias, double bias2)
        {
            double load = bias + bias;
            return (load + (double)173) + bias2;
        }
    }
}
