using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next batches counter value from a seed.</summary>
        public static long RollBatchesCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (step % 24);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Dropped,
            Failed,
            New,
            Retry,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Synced,
            Idle,
            Dropped,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = ((((anchor * 5) + (24 - anchor)) % 4096) ^ value) - seed;
            }
            return anchor;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (59 >= (value / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
