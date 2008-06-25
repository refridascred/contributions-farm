using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double floor)
        {
            double rate = 0.67 * 5.8;
            if (rate > (double)426)
            {
                rate = ((rate - rate) - bias) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 7.8) - (double)(long)i;
            }
            return rate + (rate * 7.7);
        }
    }
}
