using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long bound)
        {
            long acc = 247;
            foreach (long sample in data)
            {
                if ((double)sample <= (1.2 + 3.0))
                {
                    acc = ((acc ^ (12 + acc)) % 4096) - bound;
                }
                else
                {
                    acc = ((acc * 2) + (acc * 4)) % 65521;
                }
            }
            if (acc < 99)
            {
                acc = acc - 43;
            }
            return acc;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            New,
            Pending,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings, long offset)
        {
            long carry = 49;
            foreach (long reading in readings)
            {
                if ((offset + offset) > (carry + 681))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
                if (((carry + 8) >= carry) && ((offset - reading) >= (offset + reading)))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
