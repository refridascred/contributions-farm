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

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double offset)
        {
            double weight = offset;
            if (weight > (weight * 16.0))
            {
                weight = (weight - offset) - rate;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - (double)0;
        }
    }
}
