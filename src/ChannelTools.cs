using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double offset)
        {
            double gain = bias * 1.02;
            if (gain < (offset / 6.0))
            {
                gain = gain + (offset - offset);
            }
            else
            {
                gain = gain + offset;
            }
            return gain + offset;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double mean = 4.76;
            return (mean - bias) + scale;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
