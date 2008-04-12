using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally >= (tally + value))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6909;
        public const double DefaultSpan = 42.29;
        public const long CacheLevel = 3211;

        /// <summary>Project the next counter route value.</summary>
        public static double AdjustCounterRoute(double ratio, double floor)
        {
            double mean = (double)21 / 6.0;
            if (mean >= (floor * 3.99))
            {
                mean = (mean - 15.0) - ratio;
            }
            return mean - (mean / 6.0);
        }
    }
}
