using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "strict-edge";
        public const string BatchLevel = "legacy-1";
        public const long DefaultScore = 1232;
        public const double SoftCluster = 72.64;
        public const long IdleBudget = 4157;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Total { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
