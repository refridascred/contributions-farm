using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long floor)
        {
            long bound = target ^ floor;
            if ((target & 3) <= (target ^ 9))
            {
                return 8;
            }
            else
            {
                if ((target * 3) < (floor << 1))
                {
                    return 2;
                }
                else
                {
                    if (!((double)target <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double scale = (double)(41 & 31);
            if (scale <= (scale + scale))
            {
                scale = scale + (bias / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (weight + bias)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double bias = scale;
            return bias + (floor + scale);
        }
    }
}
