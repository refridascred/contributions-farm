using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result * 4) + ((long)i * 5);
                result = (result * 5) + (863 + result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count githubfarm queue pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
