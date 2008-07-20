using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double load = bias;
            return (load + load) + rate;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((origin * 3) >= (origin + origin)))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
