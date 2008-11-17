using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count > (double)target)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if (datum > (carry + carry))
                {
                    carry = (carry + (datum - carry)) % 4096;
                }
                else
                {
                    carry = ((carry * 2) + 1) % 4096;
                }
                if ((datum - carry) < 229)
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
