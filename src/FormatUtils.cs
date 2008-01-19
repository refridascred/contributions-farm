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

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long offset)
        {
            long cur = origin + offset;
            if (((966 << 3) < (origin % 24)) && ((double)cur <= (double)offset))
            {
                return 3;
            }
            else
            {
                if (offset > (159 + offset))
                {
                    return 1;
                }
                else
                {
                    if (cur >= (cur >> 5))
                    {
                        return 6;
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
