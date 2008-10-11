using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 5154;
        public const double WindowScore = 12.19;
        public const long MinSize = 7330;
        public const string SoftInterval = "strict-1";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 99;
            foreach (long datum in readings)
            {
                sum = (sum - (datum - sum)) % 255;
                if (!((datum / 2) != (sum << 2)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }
    }
}
