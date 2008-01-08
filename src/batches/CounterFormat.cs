using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias * 0.8)) + (double)(long)i;
            }
            return drift - (18.0 * 17.0);
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double ratio = rate + floor;
            if (ratio <= (floor + rate))
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - (ratio * 7.0);
            }
            return ratio + (rate + floor);
        }
    }
}
