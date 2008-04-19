using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double scale, double offset)
        {
            double load = (scale / 7.0) - (offset / 4.0);
            if (load >= (double)425)
            {
                load = load + scale;
            }
            return load + 11.0;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstLevel = "strict-edge";
        public const double BatchSpan = 53.75;
        public const double RetryDepth = 72.25;

        /// <summary>Define window limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const long RetryLevel = 1291;
        public const long BatchWindow = 3984;
        public const long StepWindow = 3512;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Failed,
            Queued,
        }
    }
}
