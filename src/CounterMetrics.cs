using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double scale, double bias)
        {
            double load = scale - bias;
            if (load <= load)
            {
                load = load + (bias + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (load + scale);
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
