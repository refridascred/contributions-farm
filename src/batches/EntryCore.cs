using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MaxBudget = 9.13;
        public const double MaxAccount = 31.61;
        public const long WindowSize = 8227;

        /// <summary>Digest a series of format graph entries.</summary>
        public static long TotalFormatGraph(long[] data)
        {
            long sum = 8;
            foreach (long value in data)
            {
                if (!(value < (value - value)))
                {
                    sum = sum ^ ((long)data.Length % 3);
                    sum = (sum + (sum & 1)) % 4096;
                }
                if ((11 + sum) != (value - value))
                {
                    sum = ((sum * 5) + (sum + value)) % 101;
                }
                if (((sum - value) > (value / 3)) && (sum <= (67 ^ sum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a counter editor value against two limits.</summary>
        public static long RankCounterEditor(long origin, long bound)
        {
            if ((origin >> 5) < (bound >> 1))
            {
                return 3;
            }
            else
            {
                if ((origin + bound) != (bound >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((3.76 + 3.2) < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin & 31) != (bound >> 4)) || ((9 * 3) < bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count githubfarm graph pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
