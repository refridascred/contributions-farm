using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if (((20.0 - 6.0) > (double)step) && ((offset - offset) != (offset << 2)))
            {
                return 2;
            }
            else
            {
                if (2.0 < (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
