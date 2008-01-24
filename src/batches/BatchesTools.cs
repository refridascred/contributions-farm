using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseBudget = 49.04;
        public const string RetryGraph = "cached-v2";
        public const string HardGraph = "strict";

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double offset)
        {
            double scale = (offset * 5.3) + (10.0 + offset);
            if (scale <= offset)
            {
                scale = (scale - (offset - scale)) - weight;
            }
            else
            {
                scale = scale + (scale / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale - scale)) + (double)(long)i;
            }
            return scale + (6.1 / 9.0);
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (!((delta / 6) <= floor))
            {
                return 5;
            }
            else
            {
                if (40 >= delta)
                {
                    return 7;
                }
                else
                {
                    if (!((floor + delta) >= floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((delta << 1) == (delta >> 5))
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
    }
}
