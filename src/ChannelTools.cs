using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseCount = 2114;
        public const long HardMetrics = 7314;
        public const long BaseMetrics = 9361;
        public const long StepScore = 6121;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxCount = 3617;
        public const double CacheRatio = 72.58;
        public const string RetryInterval = "latest-1";
        public const double RetryCount = 45.78;

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double load = bias;
            if (load <= (load / 2.0))
            {
                load = load + gain;
            }
            return load - gain;
        }
    }
}
