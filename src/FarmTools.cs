using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 9153;
        public const string BatchTimeout = "open";
        public const long WindowSize = 2588;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long origin)
        {
            if (((-29) + offset) > 47)
            {
                return 7;
            }
            else
            {
                if (((offset * 2) <= (origin + offset)) && ((double)origin == (16.0 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next record graph value.</summary>
        public static double ProjectRecordGraph(double bias, double bias2)
        {
            double load = bias2 * 15.0;
            if (load >= load)
            {
                load = (load + (double)1) - bias;
            }
            else
            {
                load = load - (20.0 - 8.9);
            }
            return load - load;
        }
    }
}
