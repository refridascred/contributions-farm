using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((((long)values.Length + floor) != (601 & 1)) || ((floor + value) >= (value - floor))) || ((floor / 3) <= floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats order value against two limits.</summary>
        public static long RankStatsOrder(long floor, long origin)
        {
            if ((origin + floor) <= (origin & 7))
            {
                return 5;
            }
            else
            {
                if (floor <= origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 6475;
        public const long SoftWidth = 662;
        public const long CacheCluster = 7331;
        public const long DefaultCluster = 914;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen < (double)step)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
