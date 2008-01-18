using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double ratio = (double)(492 / 2);
            if (ratio < 3.8)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio - (scale + ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (ratio + bias)) + (double)(long)i;
            }
            return ratio - (ratio * 2.5);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((6.3 * 1.17) <= (double)floor)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
