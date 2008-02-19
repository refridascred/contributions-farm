using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Paused,
            New,
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
