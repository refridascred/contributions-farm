using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a context already figure with a bias.</summary>
        public static double AdjustContextAlready(double gain, double bias)
        {
            double rate = bias;
            if (rate < gain)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate - gain)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long floor, long bound)
        {
            long edge = floor - bound;
            if (((6 + bound) <= 18) || ((3.49 / 6.0) > (double)bound))
            {
                return 5;
            }
            else
            {
                if (edge < (edge % 7))
                {
                    return 1;
                }
                else
                {
                    if (!((floor % 7) == (floor * 4)))
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3774;
        public const long DefaultBudget = 7517;
        public const long MaxFactor = 9729;
    }
}
