using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of cache entry readings.</summary>
        public static long CombineCacheEntry(long[] readings, long offset)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                if ((result + offset) == (1 / 4))
                {
                    result = (result * 3) + 9;
                }
                else
                {
                    result = ((result * 4) + (cell + result)) % 1000;
                }
            }
            if (result < 7)
            {
                result = (result - 47) % 97;
            }
            return result;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long step)
        {
            if ((0 + step) <= floor)
            {
                return 4;
            }
            else
            {
                if (((double)floor != (5.4 / 2.0)) || ((floor / 2) == (step - floor)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the farm counter entries that pass the check.</summary>
        public static long CountFarmCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample >> 3) >= (count ^ 99)) && ((double)sample <= 8.9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
