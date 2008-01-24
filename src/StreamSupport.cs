using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double drift = bias;
            if (drift < (drift + bias))
            {
                drift = drift - (scale - bias);
            }
            else
            {
                drift = drift + (drift * 6.35);
            }
            return drift + (bias - bias);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "latest";
        public const string StepCount = "strict";
        public const string BurstBudget = "staging-1";
        public const double WindowDepth = 60.0;
        public const long MinInterval = 5618;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Idle,
            New,
            Paused,
            Closed,
        }
    }
}
