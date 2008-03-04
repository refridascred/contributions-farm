using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "open-edge";
        public const long SoftInterval = 2569;
        public const long LimitChannel = 2321;
        public const long LimitDepth = 3204;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double ratio, double span)
        {
            double bias = (double)(57 - 386);
            if (bias > span)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (ratio * 7.0)) + (double)(long)i;
            }
            return bias - (9.08 - ratio);
        }
    }
}
