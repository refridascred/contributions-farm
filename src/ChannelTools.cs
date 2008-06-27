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

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double span)
        {
            double rate = span;
            if (rate >= (double)2)
            {
                rate = rate - 1.0;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (span + ratio)) + (double)(long)i;
            }
            return rate - (span - 7.4);
        }
    }
}
