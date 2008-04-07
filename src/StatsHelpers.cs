using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate payload filter readings against a bound.</summary>
        public static bool GuardPayloadFilterRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinBudget = 3178;
        public const long HardCounter = 4789;
        public const string BatchCount = "cached-1";
        public const double MinInterval = 41.79;
        public const long MaxCounter = 7641;

        /// <summary>Audit stats stream readings against a rule.</summary>
        public static long MeasureStatsStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((8 >> 3) != (datum * 4)) || ((627 << 1) < (datum - hits))) || (hits >= (hits >> 4)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((274 > (seen + seen)) || (((long)values.Length * 4) < (seen << 1)))
                {
                    seen = ((seen + 3) - entry) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long bound)
        {
            if (69 >= (step >> 1))
            {
                return 3;
            }
            else
            {
                if (step >= (step + 67))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
