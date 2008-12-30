using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next support graph value from a seed.</summary>
        public static long RollSupportGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 2) ^ state) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCount = 7161;
        public const long IdleWidth = 5545;
        public const long MaxCommits = 8036;
        public const long LimitCommits = 69;
        public const string SoftCommits = "fallback";

        /// <summary>Locate a cache metrics reading by value.</summary>
        public static long LocateCacheMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
