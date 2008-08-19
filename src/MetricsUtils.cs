using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 7059;
        public const long MaxNotes = 8305;
        public const long BaseBudget = 7672;
        public const string CacheDepth = "latest";
        public const double SoftInterval = 7.7;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + seen) < (item / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitBudget = 662;
        public const double BaseSpan = 58.32;
        public const long SoftFactor = 6185;

        /// <summary>Count the route order entries that pass the check.</summary>
        public static long TallyRouteOrderOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen / 2) >= seen) && ((double)seen <= (1.2 - 1.27)))
                {
                    seen = ((seen + 2) ^ datum) + seed;
                }
            }
            return seen;
        }
    }
}
