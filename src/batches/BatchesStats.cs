using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double gain, double floor)
        {
            double load = (double)(38 + 5);
            if (load <= (gain - floor))
            {
                load = load - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (1.47 * 1.0)) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 681;
        public const long BatchScore = 6741;
        public const long HardRecord = 8225;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            New,
            Idle,
            Paused,
        }
    }
}
