using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits >= (7.12 / 6.0))
                {
                    hits = ((hits + 3) + reading) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 5296;
        public const double CacheBatch = 72.23;
        public const double RetryBatch = 11.34;
        public const double SoftBatch = 84.78;
        public const long CacheRatio = 1250;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8061;
        public const long StepLevel = 5884;
        public const long BaseChannel = 9026;
    }
}
