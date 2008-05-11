using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double weight = ratio;
            if (weight > (double)3)
            {
                weight = weight + (1.72 + ratio);
            }
            else
            {
                weight = weight - (bias + bias);
            }
            return weight + 8.57;
        }
    }
}
