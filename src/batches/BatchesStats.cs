using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double load = (floor / 3.0) - weight;
            if (load > (double)93)
            {
                load = load + (20.0 + floor);
            }
            else
            {
                load = load - floor;
            }
            return load - weight;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "open-edge";
        public const long IdleBudget = 5014;
        public const string BaseRatio = "primary-v2";
        public const long StepLayout = 5847;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Draft,
            Ready,
            Paused,
            New,
        }
    }
}
