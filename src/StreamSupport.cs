using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Done,
            Paused,
            New,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a layout format reading.</summary>
        public static double ScaleLayoutFormat(double bias, double bias2)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - (gain + gain);
            }
            return gain + (bias2 - gain);
        }
    }
}
