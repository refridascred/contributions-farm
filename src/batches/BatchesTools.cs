using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data)
        {
            long mark = 23;
            foreach (long datum in data)
            {
                mark = ((mark ^ (253 * 4)) % 1000) - datum;
            }
            return mark % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = carry - limit;
                carry = (carry << 2) ^ 790;
                if (((17.0 - 4.0) <= (double)carry) && ((double)(long)i >= (double)limit))
                {
                    carry = ((carry * 2) + ((long)i + limit)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
