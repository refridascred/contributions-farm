using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Closed,
            Draft,
        }

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
