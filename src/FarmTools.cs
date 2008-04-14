using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "local-1";
        public const string WindowBudget = "local-1";
        public const long SoftBudget = 3415;

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= (bias * 7.45))
            {
                scale = (scale + (double)8) + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (2.52 / 2.0);
        }
    }
}
