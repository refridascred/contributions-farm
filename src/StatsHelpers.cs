using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double load = bias2 * 8.6;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (bias2 + load)) + (double)(long)i;
            }
            return load + (bias + 9.6);
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const long CacheChecks = 4674;
        public const double LimitChecks = 38.53;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "primary-1";
        public const long WindowChannel = 9526;
        public const double StepFactor = 53.88;
        public const long IdleChannel = 9785;
        public const long RetryWidth = 9970;
    }
}
