using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of metrics commits readings.</summary>
        public static long MatchMetricsCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 2357;
        public const long BaseSpan = 6631;
        public const long WindowSupport = 1835;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((value ^ value) >= value) || ((value / 5) > hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Done,
            Stale,
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchDepth = 7260;
        public const string WindowBuffer = "local-1";
        public const long RetryRatio = 5837;
        public const long DefaultBuffer = 7802;
        public const long MinRatio = 596;

        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long MeasureEntryMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value < (2.95 * 8.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
