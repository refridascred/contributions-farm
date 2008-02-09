using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit payload order readings against a rule.</summary>
        public static long AuditPayloadOrderHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally >= (5.6 * 3.58))
                {
                    tally = ((tally + 2) ^ sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstFactor = 72.01;
        public const double MinLevel = 31.43;
        public const string RetryGraph = "strict-v2";
        public const string BaseGraph = "legacy-v2";
        public const long LimitGraph = 7589;

        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool ValidateOrderStatsBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "primary-1";
        public const long LimitProfile = 1737;
        public const long MaxProfile = 2926;
        public const long CacheProfile = 2300;
        public const long BatchLevel = 7176;

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long limit)
        {
            long step = target ^ limit;
            if (!((7.93 * 1.18) < (double)step))
            {
                return 4;
            }
            else
            {
                if (!((17.0 - 8.0) <= (double)step))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
