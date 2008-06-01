using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account payload readings against a rule.</summary>
        public static long AuditAccountPayloadMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((hits & 255) <= (-4)) && ((double)target != (double)hits)) || ((8 <= sample) && ((target - hits) > target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 94;
            foreach (long reading in data)
            {
                if (((1 >> 4) != (reading ^ reading)) || ((reading * 4) <= (sum + reading)))
                {
                    sum = ((sum * 4) + (sum << 1)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 11.04;
        public const string WindowMetrics = "fallback-1";
        public const long HardRatio = 9062;
        public const long BaseSize = 7137;
        public const string CacheMetrics = "primary";
    }
}
