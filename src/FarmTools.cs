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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long target)
        {
            long next = seed - target;
            if (seed <= (target + next))
            {
                return 4;
            }
            else
            {
                if (725 >= (target * 4))
                {
                    return 5;
                }
                else
                {
                    if ((target - 21) >= (next - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
