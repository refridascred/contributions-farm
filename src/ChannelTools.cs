using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long offset, long target)
        {
            long diff = offset - target;
            if ((8.7 - 5.88) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((1.7 * 16.0) > (double)diff)
                {
                    return 7;
                }
                else
                {
                    if (!((offset << 1) < (offset & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double gain, double bias)
        {
            double ratio = bias - (bias / 4.0);
            if (ratio > ratio)
            {
                ratio = (ratio - (double)0) - gain;
            }
            return ratio - (double)5;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((6.6 * 3.21) > (double)entry) || ((entry + entry) == (entry + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
