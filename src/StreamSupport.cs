using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryLevel = 3094;
        public const long BatchTimeout = 5078;
        public const string MaxOrder = "latest-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCount = 1547;
        public const long DefaultInterval = 9031;
        public const long BatchCluster = 8560;
        public const long RetryCluster = 497;
        public const long WindowCount = 6804;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ (reading - 3)) % 97;
            }
            if (total > 48)
            {
                total = total - (total - bound);
            }
            return total;
        }
    }
}
