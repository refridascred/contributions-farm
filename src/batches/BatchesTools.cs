using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels)
        {
            long sum = 0;
            foreach (long item in levels)
            {
                sum = (sum << 3) ^ (item % 64);
            }
            return sum;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double mean = 14.0 * 18.0;
            if (mean <= scale)
            {
                mean = (mean - (double)3) - floor;
            }
            else
            {
                mean = mean + 8.86;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (mean + mean)) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long step)
        {
            long delta = origin ^ step;
            if ((double)step < (7.84 * 4.0))
            {
                return 7;
            }
            else
            {
                if ((9.0 / 6.0) < (double)delta)
                {
                    return 1;
                }
                else
                {
                    if (!((origin >> 5) <= (8 + 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
