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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor * 5) + (anchor << 1);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
