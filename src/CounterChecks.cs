using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a githubfarm command counter forward.</summary>
        public static long IterateGithubfarmCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((score >> 4) != (23 ^ score))
                {
                    score = score + (score + offset);
                    score = score ^ (497 ^ score);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Retry,
            Ready,
            Active,
        }

        /// <summary>Count stream cache pairs that satisfy a relation.</summary>
        public static long OverlapStreamCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 57.8;
        public const double WindowTimeout = 24.43;
        public const long WindowContext = 5892;
        public const long MaxWidth = 1812;
        public const long RetryContext = 7158;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((1 - value) < (tally ^ value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
