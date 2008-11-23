using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (bias2 + bias2)) + (double)(long)i) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long origin)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if (((origin - 636) >= 75) && (origin > sum))
                {
                    sum = (((sum << 2) ^ 377) % 1000) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long floor)
        {
            if ((3.2 * 13.0) >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((12.0 < (double)floor) && ((floor * 4) < target))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
