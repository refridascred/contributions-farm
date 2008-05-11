using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
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
