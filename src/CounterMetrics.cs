using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "primary-1";
        public const string CacheChecks = "latest-edge";
        public const long LimitChecks = 818;
        public const long WindowChecks = 9437;
        public const long MinChecks = 2123;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double bias)
        {
            double drift = bias;
            if (drift <= scale)
            {
                drift = drift + (bias * 9.1);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)6;
        }
    }
}
