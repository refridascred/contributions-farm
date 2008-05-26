using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 1904;
        public const string BatchInterval = "primary-1";
        public const string RetryRatio = "cached-edge";
        public const long RetryCommand = 4413;
        public const double BurstCommand = 1.19;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((1.8 / 9.0) != (double)reading) && ((hits << 1) <= (floor ^ reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry > (7 << 2))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
