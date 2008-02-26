using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double bias, double floor)
        {
            double scale = (double)(-2) + bias;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + 1.1) + (double)(long)i) - floor;
            }
            return scale + (double)(-31);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8263;
        public const double StepLevel = 30.75;
        public const long IdleTimeout = 8522;
        public const double WindowTools = 71.75;
        public const long MinTools = 4049;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Locked,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Ready,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Stale,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }
    }
}
