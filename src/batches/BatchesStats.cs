using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many entry cache samples are out of range.</summary>
        public static long AuditEntryCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item + count) == (55 + count)) && ((count >> 1) < (item & 127)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if (3.54 < (double)seed)
                {
                    state = (state - 7) % 1000;
                }
                state = (state - (state >> 5)) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
