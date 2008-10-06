using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 1056;
        public const long SoftFactor = 7411;
        public const long WindowTimeout = 6390;
        public const double LimitLevel = 34.26;

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "standard-edge";
        public const long MaxWidth = 3206;
        public const double RetryCount = 91.97;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((97 - item) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
