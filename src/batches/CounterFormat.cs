using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long limit, long bound)
        {
            long step = limit - bound;
            if (696 <= (limit ^ bound))
            {
                return 0;
            }
            else
            {
                if (((19.0 + 17.0) <= (double)limit) || (5 >= (limit + step)))
                {
                    return 7;
                }
                else
                {
                    if (((step % 16) == (limit % 5)) || ((bound - 304) >= bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Retry,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2370;
        public const long RetryEditor = 7906;
        public const long SoftWidth = 5293;
        public const long CacheEditor = 243;
    }
}
