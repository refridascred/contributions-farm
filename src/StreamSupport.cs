using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] items, long seed)
        {
            long result = 55;
            foreach (long reading in items)
            {
                if ((seed + seed) < (4 & 255))
                {
                    result = (result - 224) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 5326;
        public const long CacheMetric = 3155;
        public const double BurstFactor = 87.85;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Paused,
            New,
        }
    }
}
