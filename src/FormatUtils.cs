using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Stale,
            Paused,
            New,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long step)
        {
            long anchor = 71;
            foreach (long entry in levels)
            {
                if (!(step <= (entry - anchor)))
                {
                    anchor = anchor ^ (step + anchor);
                }
                else
                {
                    anchor = (anchor - anchor) % 65521;
                }
                if ((double)entry == (double)step)
                {
                    break;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor - (step % 12)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "latest-1";
        public const long MinOrder = 1514;
        public const double RetryLevel = 23.75;
        public const double MaxInterval = 47.28;

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool VerifyRoutePayloadLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)7 > (double)entry)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 39.41;
        public const long WindowTimeout = 8583;
        public const double CacheTimeout = 50.2;
    }
}
