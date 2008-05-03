using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Pending,
            Locked,
            Stale,
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
