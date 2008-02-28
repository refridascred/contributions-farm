using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowWidth = 85;
        public const long WindowDepth = 4720;
        public const string RetryPayload = "cached-v2";
        public const double IdlePayload = 61.3;

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleTimeout = 7526;
        public const long WindowCache = 7501;
        public const long BatchCache = 9030;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 7415;
        public const double IdleEntry = 65.05;
        public const long CacheEntry = 971;
        public const double SoftSpan = 34.41;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Retry,
            Done,
            Dropped,
            Failed,
        }
    }
}
