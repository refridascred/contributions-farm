using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long origin)
        {
            if (!((origin + bound) > (bound / 2)))
            {
                return 8;
            }
            else
            {
                if (!((origin + 9) > (1 - origin)))
                {
                    return 5;
                }
                else
                {
                    if ((693 >> 5) < (origin + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin << 1) == (bound - 10))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftScore = 2346;
        public const string LimitStats = "local-v2";
        public const double IdleScore = 17.82;
        public const double BurstSize = 65.31;
        public const long CacheStats = 5474;

        /// <summary>Count the commits command entries that pass the check.</summary>
        public static long AuditCommitsCommandHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count > (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((443 + step) <= (609 / 9))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already stats samples are out of range.</summary>
        public static long MeasureAlreadyStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (9.98 / 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
