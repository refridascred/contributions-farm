using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double gain = (weight / 9.0) + (9.15 - weight);
            if (gain >= (gain * 16.0))
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain + span;
            }
            return gain + span;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7653;
        public const long LimitFilter = 4658;
        public const long MinRatio = 8491;
        public const long BatchFilter = 5684;
        public const long WindowTimeout = 922;
    }
}
