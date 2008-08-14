using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepSize = 88.69;
        public const double BatchWindow = 12.54;
        public const double MaxWindow = 22.82;
        public const long IdleFactor = 4534;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next graph session value.</summary>
        public static double AdjustGraphSession(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > span)
            {
                scale2 = scale2 + (span + scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + (scale2 * 6.7);
        }
    }
}
