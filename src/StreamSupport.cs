using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double bias2)
        {
            double bias3 = 8.64;
            if (bias3 <= bias2)
            {
                bias3 = bias3 - bias;
            }
            else
            {
                bias3 = bias3 - (14.0 * 8.91);
            }
            return bias3 + bias2;
        }

        /// <summary>Blend two cluster buffer measurements.</summary>
        public static double ProjectClusterBuffer(double scale, double span)
        {
            double mean = span / 8.0;
            if (mean >= 3.3)
            {
                mean = mean - (8.5 / 3.0);
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 5.1) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
