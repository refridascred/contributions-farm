using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double weight, double floor)
        {
            double rate = (double)676 + (double)0;
            return (rate + floor) + weight;
        }

        /// <summary>Look up the position of a farm contributi sample.</summary>
        public static long LocateFarmContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric filter measurements.</summary>
        public static double BlendMetricFilter(double weight, double span)
        {
            double mean = (double)(807 + 8);
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + (span * 8.96);
        }
    }
}
