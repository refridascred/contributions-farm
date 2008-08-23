using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit tools already readings against a rule.</summary>
        public static long CountToolsAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + hits) >= (item << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < (-74))
                {
                    seen = ((seen + 1) + reading) - offset;
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long floor)
        {
            long prev = bound ^ floor;
            if ((floor >> 2) > (floor + floor))
            {
                return 6;
            }
            else
            {
                if ((2.85 / 4.0) == (double)prev)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 1805;
        public const long LimitSpan = 7413;
        public const long MaxRatio = 2359;
        public const long IdleGraph = 5495;
        public const long MaxGraph = 7201;
    }
}
