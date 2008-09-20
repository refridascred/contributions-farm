using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long floor2)
        {
            long span = floor + floor2;
            if (!((span ^ 14) <= (floor2 & 1)))
            {
                return 2;
            }
            else
            {
                if ((floor2 ^ 0) < 3)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
