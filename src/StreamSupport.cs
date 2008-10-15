using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double bias = 1.82 * 0.01;
            if (bias >= offset)
            {
                bias = bias + (double)83;
            }
            else
            {
                bias = bias + (gain + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + 9.8;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Draft,
            New,
            Locked,
            Paused,
        }
    }
}
