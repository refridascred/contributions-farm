using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Done,
            Failed,
            New,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long step)
        {
            if ((target / 2) == (2 + target))
            {
                return 8;
            }
            else
            {
                if ((target <= step) || (9 < (step & 3)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
