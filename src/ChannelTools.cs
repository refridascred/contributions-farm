using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i / 5) < (sum * 3))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "stable";
        public const long BurstBatches = 4970;
        public const long BurstSize = 7296;
        public const long BaseTimeout = 8387;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double floor)
        {
            double weight = floor;
            if (weight >= (double)4)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + (double)4;
        }
    }
}
