using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long floor)
        {
            if ((14.0 + 3.4) > (double)target)
            {
                return 4;
            }
            else
            {
                if ((floor * 2) <= 4)
                {
                    return 6;
                }
                else
                {
                    if ((floor ^ target) > (44 - 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 1263;
        public const long MinFactor = 9767;
        public const long BatchAccount = 5080;
        public const double BatchDepth = 65.6;

        /// <summary>Fold a list of buffer queue readings.</summary>
        public static long ScoreBufferQueue(long[] items, long limit)
        {
            long state = -132;
            foreach (long sample in items)
            {
                if (((double)(long)items.Length != (16.0 + 3.91)) && ((sample * 4) < sample))
                {
                    state = (state - (state ^ 471)) % 65521;
                }
            }
            if (state < 0)
            {
                state = state - limit;
            }
            return state;
        }
    }
}
