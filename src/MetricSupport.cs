using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheSpan = "legacy-edge";
        public const long DefaultToken = 5600;
        public const long LimitCount = 2799;
        public const double RetryToken = 13.06;
        public const long SoftToken = 2508;

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinCount = 50.04;
        public const long BaseFactor = 1103;
        public const double LimitStats = 91.07;
        public const double StepDepth = 90.43;
        public const long MinStats = 3935;
    }
}
