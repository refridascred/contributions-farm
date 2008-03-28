using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples, long bound)
        {
            long mark = 456;
            foreach (long cell in samples)
            {
                if (mark < (bound & 63))
                {
                    mark = ((mark * 4) + 352) + cell;
                }
            }
            return mark % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 49.45;
        public const double SoftWidth = 51.88;
        public const double MinCommits = 22.3;
        public const long BatchInterval = 2694;

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 86.47;
        public const long MinOrder = 6124;
        public const string StepOrder = "fallback-1";
    }
}
