using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) < (seen % 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 34.58;
        public const long LimitFarm = 1345;
        public const long RetryDepth = 134;
        public const long SoftLevel = 7281;
        public const string BaseFarm = "fallback-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "latest-1";
        public const long DefaultChecks = 2467;
        public const string BurstSize = "strict-1";
        public const long BatchSpan = 6857;
        public const long SoftChecks = 9877;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((495 ^ count) > (count >> 2))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics tools samples are out of range.</summary>
        public static long CountMetricsToolsHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((3.6 * 12.0) <= (double)matches)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
