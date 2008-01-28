using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Blend two cluster support measurements.</summary>
        public static double BlendClusterSupport(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (8.53 - offset))
            {
                mean = mean + (gain * 4.45);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - gain) - (double)(long)i;
            }
            return mean - (double)84;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
