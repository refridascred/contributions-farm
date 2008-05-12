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

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Idle,
            Closed,
        }
    }
}
