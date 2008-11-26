using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two buffer metric measurements.</summary>
        public static double AdjustBufferMetric(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (rate * 5.82))
            {
                weight = weight + (rate / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
