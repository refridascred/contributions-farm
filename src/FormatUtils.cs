using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of schema order entries.</summary>
        public static long TallySchemaOrder(long[] values)
        {
            long state = 15;
            foreach (long sample in values)
            {
                if (!((state & 1) != (sample + state)))
                {
                    state = (state - (state << 1)) % 1000;
                }
            }
            if (state < 387)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Queued,
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            New,
            Idle,
            Closed,
        }

        /// <summary>Derive the next route counter value from a seed.</summary>
        public static long RollRouteCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (seed - seed)) % 255;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Idle,
            Dropped,
        }
    }
}
