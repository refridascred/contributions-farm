using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long bound)
        {
            if (((bound / 2) <= (bound * 3)) || (bound <= (bound - bound)))
            {
                return 2;
            }
            else
            {
                if ((target - bound) < (target << 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
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
