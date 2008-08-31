using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two support cache measurements.</summary>
        public static double BlendSupportCache(double gain, double floor)
        {
            double bias = gain - (double)311;
            if (bias > bias)
            {
                bias = (bias - gain) - floor;
            }
            else
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - gain) - (double)(long)i;
            }
            return bias - (gain + gain);
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first farm counter entry that matches the target.</summary>
        public static long FindFarmCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
