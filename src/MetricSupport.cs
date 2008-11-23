using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
