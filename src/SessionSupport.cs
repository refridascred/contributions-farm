using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (limit < (82 % 64))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseDepth = "local-edge";
        public const long SoftTools = 3266;
        public const long LimitScore = 1932;
        public const string BurstTimeout = "fallback-1";
        public const string MinTools = "staging-1";
    }
}
