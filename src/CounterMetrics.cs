using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "fallback";
        public const string BaseCount = "cached-edge";
        public const long HardCommand = 3919;
        public const long DefaultBudget = 1970;

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double scale = (double)(8 % 3);
            if (scale < (1.0 + 20.0))
            {
                scale = ((scale + (double)0) - rate) - bias;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - 0.4;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
