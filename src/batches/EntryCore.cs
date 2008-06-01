using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a buffer stats counter forward.</summary>
        public static long IterateBufferStats(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (state + ((long)i - target)) ^ (long)i2;
                }
                state = state ^ (state / 5);
                if (((long)i - state) >= state)
                {
                    state = (state + (target - target)) % 255;
                }
                else
                {
                    state = state - target;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Fold a list of channel already readings.</summary>
        public static long CombineChannelAlready(long[] levels, long seed)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                score = ((score - (seed * 5)) % 4096) + cell;
            }
            return score;
        }
    }
}
