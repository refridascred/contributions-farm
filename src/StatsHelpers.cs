using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowWidth = "standard-v2";
        public const double HardMetrics = 59.5;
        public const long MinMetrics = 9795;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample / 7) < (6 - hits))
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

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long origin)
        {
            if (!((floor - floor) != (origin * 4)))
            {
                return 0;
            }
            else
            {
                if ((0 - floor) <= (floor << 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of graph context readings.</summary>
        public static long DigestGraphContext(long[] levels, long limit)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                if (((8.7 / 5.0) > (double)limit) && ((sum % 12) < sum))
                {
                    sum = (((sum << 3) ^ (sum ^ 5)) % 4096) + reading;
                }
                else
                {
                    sum = (sum + (sum * 3)) % 101;
                }
            }
            return sum;
        }
    }
}
