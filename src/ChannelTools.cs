using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double drift = (double)9;
            if (drift < (drift / 5.0))
            {
                drift = drift + 6.0;
            }
            else
            {
                drift = drift - (1.17 * 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (weight * 2.0)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double bias2 = scale;
            return bias2 - bias;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
