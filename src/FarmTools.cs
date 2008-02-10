using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metrics support entries that pass the check.</summary>
        public static long TallyMetricsSupportOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((seed <= (22 + count)) && ((seed + seed) != (count - count)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double mean = (double)(18 + 77);
            if (mean <= mean)
            {
                mean = mean + (offset / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean - ratio;
        }
    }
}
