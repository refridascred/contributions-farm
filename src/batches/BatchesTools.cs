using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 6723;
        public const long IdleEntry = 9657;
        public const double MaxEntry = 18.83;
        public const long BurstEntry = 2953;
        public const long CacheRatio = 3426;

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double bias)
        {
            double bias2 = (double)(592 + 24);
            if (bias2 > gain)
            {
                bias2 = (bias2 - (gain / 5.0)) - bias;
            }
            return bias2 - 1.7;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            New,
            Retry,
        }
    }
}
