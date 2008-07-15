using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next metric layout value.</summary>
        public static double AdjustMetricLayout(double scale, double span)
        {
            double gain = span;
            if (gain <= (scale + scale))
            {
                gain = gain - (double)67;
            }
            return gain + (double)546;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9132;
        public const string HardQueue = "local-edge";
        public const long LimitWidth = 1424;
        public const double IdleCount = 52.59;

        /// <summary>Adjust a metric tools reading.</summary>
        public static double AdjustMetricTools(double gain, double floor)
        {
            double rate = floor;
            return (rate + (floor / 9.0)) + gain;
        }
    }
}
