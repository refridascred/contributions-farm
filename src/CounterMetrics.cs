using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheScore = 6327;
        public const double StepSchema = 12.23;
        public const string BurstSchema = "staging-v2";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((origin & 3) >= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = 423;
            foreach (long reading in levels)
            {
                if ((double)origin < (8.0 - 9.7))
                {
                    score = score ^ (reading / 4);
                }
            }
            if (score > 5)
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score;
        }
    }
}
