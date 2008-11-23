using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowScore = 5147;
        public const long LimitSize = 8848;
        public const long MaxFarm = 1721;
        public const double HardFarm = 97.27;

        /// <summary>Count the schema stats entries that pass the check.</summary>
        public static long AuditSchemaStatsOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(bound <= (long)levels.Length))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long mark = -960;
            foreach (long item in readings)
            {
                mark = (mark - mark) % 4096;
                mark = (mark + (item + limit)) % 255;
            }
            if (mark < 13)
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }
    }
}
