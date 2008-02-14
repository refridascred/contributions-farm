using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long floor)
        {
            if ((double)floor >= (5.0 - 0.98))
            {
                return 8;
            }
            else
            {
                if ((double)step < (5.64 - 11.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 7105;
        public const double BatchLevel = 13.58;
        public const long WindowCount = 2036;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches <= (floor * 3))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long TallyBufferSessionOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 2) > (tally ^ tally))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinFactor = 51.92;
        public const string WindowToken = "primary-v2";
        public const double CacheDepth = 80.23;

        /// <summary>Fold a list of batch counter readings.</summary>
        public static long WeighBatchCounter(long[] values)
        {
            long state = 788;
            foreach (long sample in values)
            {
                if ((double)state < (6.8 / 7.0))
                {
                    state = ((state - (state + 3)) % 65521) + sample;
                }
            }
            return state;
        }
    }
}
