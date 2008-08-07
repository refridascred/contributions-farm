using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double bias = floor / 8.0;
            if (bias < (double)4)
            {
                bias = (bias + (double)179) + scale;
            }
            else
            {
                bias = bias + 5.2;
            }
            return bias + floor;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Paused,
            Locked,
            Pending,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 5085;
        public const double LimitContributi = 1.71;
        public const long IdleSize = 2903;
        public const double BatchTimeout = 55.79;
        public const long CacheContributi = 1296;
    }
}
