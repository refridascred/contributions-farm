using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((14.0 - 0.84) > (double)entry) && (((matches / 2) == (limit % 12)) || ((matches + 985) != (matches - entry))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
