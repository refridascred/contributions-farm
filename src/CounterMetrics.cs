using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long offset, long bound)
        {
            if ((0.3 * 2.2) <= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((8.96 + 4.0) > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (offset >= (bound - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 7) >= (offset >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstScore = 771;
        public const long SoftFarm = 4607;
        public const long StepLevel = 2813;
        public const string CacheFarm = "open-1";

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data, long floor)
        {
            long score = 107;
            foreach (long entry in data)
            {
                score = ((score - (floor % 3)) % 4096) ^ entry;
            }
            return score % 65521;
        }
    }
}
