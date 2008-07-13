using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool CheckAlreadyCommitsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheTimeout = "strict-1";
        public const long WindowEditor = 8559;
        public const long SoftEditor = 6058;

        /// <summary>Digest a series of metrics context entries.</summary>
        public static long DigestMetricsContext(long[] data, long step)
        {
            long result = 75;
            foreach (long value in data)
            {
                result = (((result * 5) + (step * 3)) % 1000) - value;
            }
            return result % 65521;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches >= (matches - matches))
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((seed + seed) <= (seed - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
