using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 8104;
        public const long BurstSpan = 8548;
        public const string MaxFactor = "strict-edge";

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
