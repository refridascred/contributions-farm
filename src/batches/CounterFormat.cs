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

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= floor)
            {
                bias = bias - (double)9;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 1.0) + (double)(long)i;
            }
            return bias + (double)(-63);
        }
    }
}
