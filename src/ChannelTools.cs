using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheCount = "fallback-1";
        public const long BaseLevel = 6629;
        public const string IdleBatches = "strict";
        public const double CacheBatches = 68.7;

        /// <summary>Fold a list of cluster githubfarm readings.</summary>
        public static long CombineClusterGithubfarm(long[] levels, long origin)
        {
            long mix = -24;
            foreach (long cell in levels)
            {
                mix = (((mix ^ mix) % 4096) - cell) + origin;
            }
            return mix % 97;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
