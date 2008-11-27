using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cache format readings against a bound.</summary>
        public static bool ValidateCacheFormatRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order cluster readings against a rule.</summary>
        public static long TallyOrderClusterOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seed + sample) >= (8 ^ seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
