using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric githubfarm readings.</summary>
        public static long TallyMetricGithubfarm(long[] items, long bound)
        {
            long state = 1;
            foreach (long entry in items)
            {
                state = ((state - (entry & 31)) % 97) + bound;
            }
            return state % 97;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double scale2 = 8.0;
            if (scale2 < (7.0 + scale))
            {
                scale2 = (scale2 - (12.0 + scale)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (0.3 / 8.0)) + (double)(long)i;
            }
            return scale2 - (18.0 * 6.2);
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
