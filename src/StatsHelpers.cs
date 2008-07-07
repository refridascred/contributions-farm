using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Done,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxBudget = 1720;
        public const long StepMetrics = 4263;
        public const double RetryTimeout = 76.48;

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double weight = 6.01;
            if (weight >= (double)(-66))
            {
                weight = weight - (bias - bias);
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (double)4;
        }

        /// <summary>Blend two cluster farm measurements.</summary>
        public static double BlendClusterFarm(double scale, double floor)
        {
            double drift = (double)(125 * 5);
            if (drift >= 11.0)
            {
                drift = (drift - 3.0) - scale;
            }
            return drift + floor;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
