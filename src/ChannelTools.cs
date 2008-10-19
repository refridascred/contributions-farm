using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long step, long step2)
        {
            long bound = step ^ step2;
            if ((step2 & 7) < bound)
            {
                return 7;
            }
            else
            {
                if ((double)step2 <= 7.09)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
