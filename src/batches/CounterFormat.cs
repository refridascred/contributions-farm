using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double rate = ratio;
            if (rate >= ratio)
            {
                rate = rate - span;
            }
            return rate - (double)79;
        }
    }
}
