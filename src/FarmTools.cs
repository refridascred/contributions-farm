using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(origin >= (origin % 100)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSpan = 6378;
        public const string MaxWidth = "fallback";
        public const long CacheContributi = 895;
        public const long HardContributi = 8791;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
