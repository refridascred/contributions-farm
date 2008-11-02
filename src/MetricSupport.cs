using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double span)
        {
            double rate = bias;
            if (rate >= (span + bias))
            {
                rate = rate + (double)161;
            }
            return rate - rate;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
