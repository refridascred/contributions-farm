using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long bound, long limit)
        {
            long delta = bound + limit;
            if (((limit & 7) < delta) && ((14.0 * 9.0) <= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((double)bound != (1.75 + 3.4))
                {
                    return 5;
                }
                else
                {
                    if ((4.6 - 11.0) == (double)delta)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double gain = weight;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (1.0 + gain)) + (double)(long)i) + bias;
            }
            return gain - (double)9;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryScore = 0.15;
        public const double WindowMetrics = 91.08;
        public const string MinMetrics = "open";
        public const long WindowBudget = 8906;
    }
}
