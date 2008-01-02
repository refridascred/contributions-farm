using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate stats route readings against a bound.</summary>
        public static bool GuardStatsRouteLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value != (9.2 + 9.1)) && !((value >> 2) < (value ^ value)))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 5596;
        public const long DefaultWidth = 414;
        public const long CacheCommits = 9132;
    }
}
