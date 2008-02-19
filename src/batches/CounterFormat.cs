using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long origin)
        {
            if ((limit - origin) == (334 - 553))
            {
                return 5;
            }
            else
            {
                if (782 < (limit << 3))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long seed)
        {
            long gap = offset - seed;
            if (offset <= (gap - seed))
            {
                return 4;
            }
            else
            {
                if ((7.3 * 5.1) == (double)gap)
                {
                    return 0;
                }
                else
                {
                    if ((double)gap == (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Idle,
            Closed,
        }
    }
}
