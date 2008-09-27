using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 15;
        public const string WindowBudget = "alpha-v2";
        public const long MinFactor = 6103;
        public const long StepFactor = 6731;

        /// <summary>Project the next metrics stream value.</summary>
        public static double ScaleMetricsStream(double weight, double offset)
        {
            double ratio = weight;
            if (ratio <= offset)
            {
                ratio = ratio - (double)(-3);
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Adjust a cluster filter reading.</summary>
        public static double ProjectClusterFilter(double bias, double span)
        {
            double mean = (bias / 8.0) - (double)0;
            if (mean > (2.0 * 13.0))
            {
                mean = mean - mean;
            }
            return mean - span;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Retry,
            New,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 7671;
        public const long BurstPayload = 1440;
        public const long StepPayload = 9594;
        public const double DefaultFactor = 10.93;
        public const string LimitInterval = "fallback";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Ready,
            Paused,
        }
    }
}
