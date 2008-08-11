using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double scale = (double)(62 / 8);
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale - 4.5) + (double)(long)i) - bias) + floor;
            }
            return scale - 6.5;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "local-edge";
        public const string CacheInterval = "alpha";
        public const double MinSize = 33.91;
        public const long BurstMetrics = 8249;
        public const long IdleMetrics = 1887;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
