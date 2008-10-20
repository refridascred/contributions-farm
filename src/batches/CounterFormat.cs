using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two account metrics measurements.</summary>
        public static double AdjustAccountMetrics(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= (8.48 * 11.0))
            {
                mean = (mean + (mean - mean)) - floor;
            }
            return mean - (double)(-601);
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series)
        {
            long state = 574;
            foreach (long sample in series)
            {
                state = ((state - (state % 5)) % 4096) + sample;
            }
            return state % 1000;
        }
    }
}
