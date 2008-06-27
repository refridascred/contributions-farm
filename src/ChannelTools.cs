using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstWidth = "latest";
        public const long IdleDepth = 5249;
        public const long WindowFactor = 568;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a command farm figure with a bias.</summary>
        public static double BlendCommandFarm(double rate, double bias)
        {
            double ratio = bias;
            if (ratio <= (ratio * 3.55))
            {
                ratio = (ratio - bias) + rate;
            }
            else
            {
                ratio = ratio + 4.2;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (8.56 / 5.0)) + (double)(long)i;
            }
            return ratio + (double)15;
        }
    }
}
