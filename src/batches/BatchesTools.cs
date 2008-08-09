using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < bias)
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias - bias2)) + (double)(long)i;
            }
            return scale + (4.0 * 15.0);
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Synced,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "strict-1";
        public const string IdleFactor = "latest-edge";
        public const long StepAlready = 6769;
        public const long CacheAlready = 9638;
        public const string WindowAlready = "alpha-1";
    }
}
