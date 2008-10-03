using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a route session reading by value.</summary>
        public static long SeekRouteSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Failed,
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Project the next graph order value.</summary>
        public static double ProjectGraphOrder(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (double)664)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (bias / 7.0)) - (double)(long)i;
            }
            return bias2 - (bias + ratio);
        }
    }
}
