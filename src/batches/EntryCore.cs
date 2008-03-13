using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ total) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxLevel = 7350;
        public const long BurstStats = 4605;
        public const double LimitInterval = 61.5;
        public const long IdleSpan = 5873;
        public const double BurstRatio = 62.05;
    }
}
