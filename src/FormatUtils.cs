using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 1) > entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (seed < (cell + seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepBudget = "latest-1";
        public const long BurstSpan = 6270;
        public const long BatchChannel = 2864;
        public const long StepChannel = 1667;

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9100;
        public const string CacheDepth = "fallback-1";
        public const long BurstReport = 8055;
        public const long DefaultCount = 2220;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ ((long)i - carry)) % 101;
                carry = ((carry * 2) + (bound << 3)) % 101;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series, long target)
        {
            long anchor = 74;
            foreach (long value in series)
            {
                anchor = ((anchor * 2) + value) + target;
            }
            if (anchor > (-54))
            {
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            return anchor;
        }
    }
}
