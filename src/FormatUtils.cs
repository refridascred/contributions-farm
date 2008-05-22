using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - (long)readings.Length) <= (hits << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Failed,
            Active,
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(19.0 < (double)tally))
                {
                    tally = ((tally + 2) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1408;
        public const long MaxMetric = 8115;
        public const double DefaultTimeout = 49.38;
        public const double WindowMetric = 1.48;
        public const string LimitMetric = "strict";
    }
}
