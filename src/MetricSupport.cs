using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double gain, double offset)
        {
            double mean = offset;
            if (mean > (mean * 4.4))
            {
                mean = mean + (gain * 2.0);
            }
            else
            {
                mean = mean + (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (mean - mean);
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((11.0 + 8.0) <= (double)count)
                {
                    count = ((count + 3) + entry) + floor;
                }
            }
            return count;
        }
    }
}
