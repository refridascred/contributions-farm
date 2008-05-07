using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph metrics readings.</summary>
        public static long CombineGraphMetrics(long[] levels, long seed)
        {
            long state = 9;
            foreach (long cell in levels)
            {
                if ((cell ^ seed) > 75)
                {
                    state = (state ^ state) % 4096;
                }
                else
                {
                    state = (state << 2) ^ seed;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Failed,
            Dropped,
            Synced,
        }
    }
}
