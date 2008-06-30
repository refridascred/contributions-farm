using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double weight = bias;
            if (weight >= (bias - 18.0))
            {
                weight = (weight - weight) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight - bias)) + (double)(long)i;
            }
            return weight + (double)4;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Failed,
            Queued,
            Retry,
        }
    }
}
