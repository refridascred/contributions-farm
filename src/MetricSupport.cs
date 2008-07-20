using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every batches checks entry stays within the limit.</summary>
        public static bool GuardBatchesChecksRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseScore = "alpha-edge";
        public const string WindowFactor = "legacy-v2";
        public const double CacheSchema = 61.61;

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 29.09;
        public const long SoftCount = 4191;
        public const long LimitCache = 9546;
        public const long DefaultCache = 6499;
    }
}
