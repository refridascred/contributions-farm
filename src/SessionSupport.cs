using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 8944;
        public const long MinSize = 3456;
        public const double WindowDepth = 39.19;
        public const double CacheCount = 1.47;
        public const long MinBatches = 4837;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseRatio = 1336;
        public const double LimitToken = 32.42;
        public const long LimitLevel = 5791;
        public const long RetryLevel = 8533;
        public const long IdleDepth = 6804;

        /// <summary>Count order buffer pairs that satisfy a relation.</summary>
        public static long OverlapOrderBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
