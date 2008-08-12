using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchWidth = "standard-v2";
        public const string IdleInterval = "local-edge";
        public const string HardCount = "cached-edge";

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double load = (double)(147 / 3);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + load) + (double)(long)i) - gain;
            }
            return load + (span / 8.0);
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double load = bias;
            if (load >= (load + scale))
            {
                load = load - (double)16;
            }
            return load - (scale * 9.0);
        }
    }
}
