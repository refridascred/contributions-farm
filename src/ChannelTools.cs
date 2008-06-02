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

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4579;
        public const long BurstCount = 4817;
        public const long CacheFactor = 6647;
        public const string DefaultStats = "stable";
        public const long CacheDepth = 1027;

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
