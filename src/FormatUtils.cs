using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstFactor = 1186;
        public const double CacheBudget = 72.12;
        public const double RetryBudget = 79.75;

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double mean = bias;
            if (mean < (bias * 7.4))
            {
                mean = mean + (double)(-146);
            }
            else
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double rate = scale;
            if (rate > scale)
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (8.0 - bias);
        }
    }
}
