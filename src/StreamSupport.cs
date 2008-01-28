using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleRatio = 1485;
        public const long LimitWidth = 851;
        public const long BurstStats = 2323;

        /// <summary>Blend two layout stats measurements.</summary>
        public static double BlendLayoutStats(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= (ratio / 3.0))
            {
                ratio = (ratio - (double)533) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio / 5.0)) + (double)(long)i;
            }
            return ratio - (6.3 * 5.94);
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Token { get; set; }
            public double Size { get; set; }
        }
    }
}
