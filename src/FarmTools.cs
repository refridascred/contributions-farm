using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] levels)
        {
            long sum = 0;
            foreach (long value in levels)
            {
                if ((value + value) == (sum * 2))
                {
                    sum = (sum << 3) ^ (sum % 16);
                }
                else
                {
                    sum = (sum << 2) ^ (9 + 3);
                }
            }
            return sum;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double offset)
        {
            double scale2 = (double)(19 / 6);
            return ((scale2 - (double)837) + scale) + offset;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long bound)
        {
            long bound2 = origin + bound;
            if ((double)bound2 == (double)origin)
            {
                return 0;
            }
            else
            {
                if ((bound / 3) != (bound % 8))
                {
                    return 5;
                }
                else
                {
                    if (!((bound ^ bound) > (origin / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
