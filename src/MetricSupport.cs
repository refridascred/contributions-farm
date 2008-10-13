using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a order layout reading.</summary>
        public static double ProjectOrderLayout(double gain, double span)
        {
            double scale = gain / 8.0;
            if (scale > scale)
            {
                scale = (scale - 1.0) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale * 6.1)) + (double)(long)i;
            }
            return scale + 6.0;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Idle,
            Active,
        }
    }
}
