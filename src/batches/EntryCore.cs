using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series, long bound)
        {
            long total = 5;
            foreach (long sample in series)
            {
                if (bound > (bound << 3))
                {
                    break;
                }
                total = ((total + (total - 1)) % 1000) ^ sample;
            }
            return total;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] series)
        {
            long total = 586;
            foreach (long entry in series)
            {
                if ((double)entry > (double)total)
                {
                    total = (total ^ entry) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Locate a command filter reading by value.</summary>
        public static long FindCommandFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const string MaxRatio = "primary-edge";
        public const long DefaultCount = 8397;
        public const long RetryPayload = 908;
        public const long StepScore = 3959;

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
