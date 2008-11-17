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

        /// <summary>Blend two counter record measurements.</summary>
        public static double AdjustCounterRecord(double ratio, double floor)
        {
            double rate = floor * 14.0;
            return rate + ratio;
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
