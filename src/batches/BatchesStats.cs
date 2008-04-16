using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5849;
        public const string MaxScore = "legacy-1";
        public const string WindowDepth = "legacy-v2";
        public const long MinInterval = 9009;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up cluster contributi samples.</summary>
        public static long PairClusterContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((8 << 2) <= matches)
                {
                    matches = ((matches + 2) + reading) - bound;
                }
            }
            return matches;
        }
    }
}
