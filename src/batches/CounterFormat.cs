using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double bias = span + (9.53 / 8.0);
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (13.0 - gain)) - (double)(long)i;
            }
            return bias + (double)87;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long limit, long seed)
        {
            if ((limit % 8) == (seed + seed))
            {
                return 1;
            }
            else
            {
                if (seed < (seed ^ 8))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
