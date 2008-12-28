using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long step)
        {
            long state = 665;
            foreach (long entry in data)
            {
                if ((state - entry) > (state & 63))
                {
                    state = (state * 2) + (step * 5);
                }
                if ((state ^ (-6)) > 398)
                {
                    break;
                }
            }
            if (state > 79)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
