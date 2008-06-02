using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count stats stream pairs that satisfy a relation.</summary>
        public static long MatchStatsStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "strict";
        public const long MaxPayload = 6917;
        public const long LimitBudget = 6881;
        public const long RetrySpan = 9400;
        public const long BatchPayload = 4486;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 90.64;
        public const double MaxBuffer = 54.0;
        public const long CacheWidth = 8071;
        public const long CacheBuffer = 3472;

        /// <summary>Count account buffer pairs that satisfy a relation.</summary>
        public static long OverlapAccountBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
