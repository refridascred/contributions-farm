using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheRatio = 6321;
        public const double SoftTimeout = 51.51;
        public const long IdleFactor = 4888;
        public const long BurstFarm = 3941;
        public const long BatchSize = 4779;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double gain2 = gain;
            for (int i = 0; i < 7; i++)
            {
                gain2 = ((gain2 + 5.88) + (double)(long)i) + offset;
            }
            return gain2 + (double)206;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftBudget = "alpha-edge";
        public const long CacheWidth = 4409;
        public const long BaseOrder = 8427;
        public const string BurstOrder = "alpha-edge";
        public const long RetryOrder = 262;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Region { get; set; }
            public double Mode { get; set; }
        }
    }
}
