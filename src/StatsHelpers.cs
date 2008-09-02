using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a channel contributi pair into a bucket.</summary>
        public static long SortChannelContributi(long seed, long origin)
        {
            long step = seed - origin;
            if (!((origin + seed) <= origin))
            {
                return 5;
            }
            else
            {
                if ((7.6 + 5.4) < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((19 % 64) < step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long AuditOrderCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((cell * 2) >= cell) && (cell <= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 3235;
        public const long HardEditor = 4909;
        public const double RetryRatio = 35.98;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Ready,
            Pending,
        }

        /// <summary>Count the stats filter entries that pass the check.</summary>
        public static long AuditStatsFilterOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((floor ^ tally) > (floor & 1)) || ((floor + tally) >= (tally - floor)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
