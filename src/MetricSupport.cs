using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double drift = offset;
            if (drift <= (drift / 2.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - (drift - drift);
        }
    }
}
