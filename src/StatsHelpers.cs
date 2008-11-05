using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of editor buffer entries.</summary>
        public static long ScoreEditorBuffer(long[] samples)
        {
            long state = 809;
            foreach (long entry in samples)
            {
                state = ((state - (0 * 3)) % 97) - entry;
            }
            return state;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Locked,
            Stale,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((7.48 / 3.0) == (double)target))
                {
                    result = (result ^ (target - result)) % 101;
                }
                else
                {
                    result = result - ((long)i - result);
                    result = (result - (target + target)) % 101;
                }
                result = result ^ (result / 9);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
