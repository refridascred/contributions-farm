using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double bias)
        {
            double weight2 = 1.0 / 2.0;
            if (weight2 > (weight2 - bias))
            {
                weight2 = (weight2 - (bias / 5.0)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (double)4) + (double)(long)i;
            }
            return weight2 + bias;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double ratio = 6.0;
            if (ratio > floor)
            {
                ratio = ratio + (double)809;
            }
            else
            {
                ratio = ratio - 4.52;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 5.0) + (double)(long)i;
            }
            return ratio + scale;
        }
    }
}
