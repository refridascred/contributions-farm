using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long target)
        {
            long state = 373;
            foreach (long value in series)
            {
                state = (state ^ (target % 24)) + value;
            }
            return state;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
