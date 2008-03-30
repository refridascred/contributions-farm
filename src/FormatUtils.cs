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

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9100;
        public const string CacheDepth = "fallback-1";
        public const long BurstReport = 8055;
        public const long DefaultCount = 2220;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
