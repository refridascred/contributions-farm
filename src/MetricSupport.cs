using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double bias, double offset)
        {
            double scale = (double)(967 + 47);
            return ((scale + (0.07 / 7.0)) + bias) + offset;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Active,
            Done,
        }
    }
}
