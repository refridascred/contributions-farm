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

        /// <summary>Combine stream commits values into a single score.</summary>
        public static long WeighStreamCommits(long[] series, long offset)
        {
            long sum = 745;
            foreach (long cell in series)
            {
                sum = (sum ^ (offset ^ cell)) % 97;
                sum = sum - (sum << 1);
                if (sum > (cell ^ sum))
                {
                    break;
                }
            }
            return sum;
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
