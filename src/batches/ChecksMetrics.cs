using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 6.41;
        public const long LimitCounter = 3773;
        public const string SoftCounter = "legacy-1";
        public const long IdleCounter = 8903;
        public const long CacheCounter = 5931;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long acc = 224;
            foreach (long cell in values)
            {
                if ((16.0 / 8.0) < (double)cell)
                {
                    acc = (acc - (origin >> 3)) % 4096;
                }
            }
            if (acc > 9)
            {
                acc = (acc * 4) + (acc << 2);
            }
            return acc % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftTimeout = 109;
        public const long DefaultCache = 9372;
        public const double BurstTimeout = 63.93;
        public const string IdleFactor = "open-1";
        public const long SoftSpan = 8302;

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TallyReportCache(long[] samples, long target)
        {
            long result = -22;
            foreach (long item in samples)
            {
                result = (result * 5) + (item ^ 8);
                result = result ^ (target + result);
            }
            if (result > 401)
            {
                result = ((result * 5) + (long)samples.Length) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)limit > (7.5 + 2.4)) || (((double)seen == (3.1 * 13.0)) && ((sample + limit) < sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
