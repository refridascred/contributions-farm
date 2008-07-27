using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph tools figure with a bias.</summary>
        public static double SmoothGraphTools(double bias, double floor)
        {
            double load = (double)770 + floor;
            if (load >= 0.58)
            {
                load = load + (double)34;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (bias - bias)) - (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Measure how many cache cluster samples are out of range.</summary>
        public static long CountCacheClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((362 + tally) <= value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Active,
            Closed,
            Done,
            Ready,
        }
    }
}
