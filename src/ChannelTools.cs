using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data, long target)
        {
            long acc = -6;
            foreach (long sample in data)
            {
                if (sample < acc)
                {
                    acc = (acc + sample) - target;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Blend two graph layout measurements.</summary>
        public static double AdjustGraphLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (bias / 2.0))
            {
                drift = drift - drift;
            }
            return drift + bias;
        }
    }
}
