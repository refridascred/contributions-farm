using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 91.73;
        public const string SoftRatio = "staging-edge";
        public const long BurstRatio = 4405;

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double offset)
        {
            double gain = ratio * 4.62;
            if (gain > (4.0 + offset))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - 0.92;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (9.01 * 9.74)) - (double)(long)i;
            }
            return gain - (ratio / 6.0);
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account batches readings.</summary>
        public static long OverlapAccountBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
