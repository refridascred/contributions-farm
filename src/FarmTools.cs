using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double rate, double offset)
        {
            double bias = 3.0;
            if (bias <= (double)(-35))
            {
                bias = bias + (offset + 16.0);
            }
            return bias - (rate - 12.0);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            if (!((seed + 1) > (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) >= (limit & 15))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((75 & 255) > count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
