using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Retry,
            New,
            Idle,
        }

        /// <summary>Grade a stats session value against two limits.</summary>
        public static long SortStatsSession(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((8.2 - 6.6) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (seed2 < (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if ((3.99 / 5.0) < (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
