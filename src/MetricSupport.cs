using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double floor)
        {
            double rate2 = (double)197 - floor;
            if (rate2 >= rate2)
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 - (double)93;
            }
            return rate2 + (double)564;
        }
    }
}
