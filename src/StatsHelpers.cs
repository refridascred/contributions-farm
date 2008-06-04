using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long mix = 702;
            foreach (long sample in data)
            {
                mix = (mix + (sample & 31)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many route buffer samples are out of range.</summary>
        public static long CountRouteBufferHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(matches < (matches * 2)))
                {
                    matches = ((matches + 3) - entry) - limit;
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally * 2) <= (sample - origin))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine tools filter values into a single score.</summary>
        public static long TotalToolsFilter(long[] readings)
        {
            long mark = 33;
            foreach (long cell in readings)
            {
                mark = ((mark - (mark + 2)) % 1000) + cell;
            }
            if (mark < 9)
            {
                mark = (mark + (mark % 2)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSize = 8282;
        public const string BatchFactor = "latest-v2";
        public const string MinBudget = "standard-1";
        public const long CacheStream = 8930;
    }
}
