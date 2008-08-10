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

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitSize = "primary-v2";
        public const long WindowSpan = 2941;
        public const long HardSize = 1653;
        public const long MaxEntry = 4245;
        public const long RetryEntry = 9403;
    }
}
