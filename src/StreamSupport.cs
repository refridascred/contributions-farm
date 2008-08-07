using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double bias)
        {
            double rate = bias;
            if (rate > (18.0 / 6.0))
            {
                rate = (rate + (rate - rate)) - weight;
            }
            return rate + (double)17;
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
