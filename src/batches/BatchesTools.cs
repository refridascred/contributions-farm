using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)item <= (5.5 / 7.0)))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 844;
        public const string MaxRatio = "stable-edge";
        public const string CacheInterval = "latest-1";
        public const string CacheSize = "fallback";

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7282;
        public const long IdleToken = 8941;
        public const double RetryToken = 19.56;
        public const long StepCount = 6499;
        public const long BatchToken = 7519;
    }
}
