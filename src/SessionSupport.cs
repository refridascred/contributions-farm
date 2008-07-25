using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double bias)
        {
            double mean = gain;
            if (mean < (gain / 8.0))
            {
                mean = mean - (6.24 - mean);
            }
            else
            {
                mean = mean - bias;
            }
            return mean - bias;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length < (double)839)
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long offset)
        {
            if ((88 + offset) > seed)
            {
                return 5;
            }
            else
            {
                if ((offset / 4) < (seed - offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
