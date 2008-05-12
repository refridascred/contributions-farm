using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the window stats entries that pass the check.</summary>
        public static long AuditWindowStatsMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((step << 2) >= (hits - sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit editor stream readings against a rule.</summary>
        public static long TallyEditorStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) != (seen ^ cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a contributi cluster sample.</summary>
        public static long LookupContributiClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((53 * 2) < offset) && ((sum + (long)i) < (long)i))
                {
                    sum = sum + (6 + 5);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
