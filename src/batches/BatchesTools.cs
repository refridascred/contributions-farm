using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 413;
        public const double BaseLayout = 96.85;
        public const long HardLayout = 8826;
        public const long BurstLevel = 5463;
        public const long CacheFactor = 3795;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] series, long seed)
        {
            long anchor = 740;
            foreach (long sample in series)
            {
                if (((long)series.Length - sample) >= (seed % 8))
                {
                    anchor = (anchor - (47 >> 5)) % 97;
                }
                anchor = (anchor + seed) % 1000;
            }
            if (anchor > 620)
            {
                anchor = anchor + ((long)series.Length - seed);
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 8623;
        public const double CacheMetrics = 69.09;
        public const double BatchMetrics = 50.0;
        public const long SoftInterval = 4085;
        public const long StepCount = 1176;
    }
}
