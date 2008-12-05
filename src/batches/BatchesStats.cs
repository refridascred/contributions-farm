using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((777 / 2) < (cell + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile session readings.</summary>
        public static long FoldProfileSession(long[] data)
        {
            long anchor = 855;
            foreach (long entry in data)
            {
                if ((anchor + 55) >= entry)
                {
                    anchor = anchor ^ 65;
                }
            }
            if (anchor < 17)
            {
                anchor = anchor - (-631);
            }
            return anchor % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "staging-edge";
        public const long DefaultInterval = 3248;
        public const long BatchBudget = 1853;

        /// <summary>Compare every pair of schema filter readings.</summary>
        public static long MatchSchemaFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
