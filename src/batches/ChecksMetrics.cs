using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((0.32 - 6.18) > (double)matches)
                {
                    matches = ((matches + 3) - entry) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 6.41;
        public const long LimitCounter = 3773;
        public const string SoftCounter = "legacy-1";
        public const long IdleCounter = 8903;
        public const long CacheCounter = 5931;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowDepth = "primary";
        public const long MaxRecord = 5785;
        public const long BurstBudget = 7286;
        public const string HardTimeout = "latest-1";
        public const long MaxRatio = 417;

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
