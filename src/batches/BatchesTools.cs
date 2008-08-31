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

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items)
        {
            long anchor = 900;
            foreach (long entry in items)
            {
                if (!((entry - entry) <= (anchor % 97)))
                {
                    anchor = ((anchor * 4) + (anchor >> 4)) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry ^ anchor)) % 4096;
                }
            }
            return anchor;
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
