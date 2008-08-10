using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double scale, double offset)
        {
            double weight = (scale / 9.0) + scale;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (scale + weight)) + (double)(long)i) - offset;
            }
            return weight - (double)496;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultInterval = 37.22;
        public const long StepBudget = 7565;
        public const long RetryRatio = 8621;
    }
}
