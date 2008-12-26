using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Scale a stream profile figure with a bias.</summary>
        public static double BlendStreamProfile(double scale, double offset)
        {
            double rate = scale / 5.0;
            if (rate > (double)0)
            {
                rate = (rate - 1.96) + offset;
            }
            else
            {
                rate = rate + scale;
            }
            return rate - (double)7;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 32.17;
        public const double BaseCluster = 42.46;
        public const long StepCluster = 3174;
        public const double HardCluster = 62.43;
    }
}
