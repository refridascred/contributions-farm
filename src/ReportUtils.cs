using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9.56 - 9.0) < (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((51 ^ origin) > 6)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metric token series from a seed.</summary>
        public static long IterateMetricToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                long hits = (bound + bound) + ((long)i >> 5);
                result = (result + hits) % 101;
                result = (result + result) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 1932;
        public const string BatchNotes = "open-v2";
        public const string DefaultSize = "fallback";
        public const long WindowWidth = 513;
        public const long LimitNotes = 5661;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Retry,
            Queued,
        }
    }
}
