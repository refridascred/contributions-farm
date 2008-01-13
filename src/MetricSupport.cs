using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally + sample) != (42 ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token queue measurements.</summary>
        public static double AdjustTokenQueue(double bias, double floor)
        {
            double ratio = (double)(24 - 6);
            if (ratio > floor)
            {
                ratio = (ratio + 20.0) + bias;
            }
            return ratio - ratio;
        }
    }
}
