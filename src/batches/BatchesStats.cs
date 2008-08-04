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

        /// <summary>Count the batch notes entries that pass the check.</summary>
        public static long TallyBatchNotesHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((6.6 + 7.32) < (double)seen)
                {
                    seen = ((seen + 2) ^ item) + limit;
                }
            }
            return seen;
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
