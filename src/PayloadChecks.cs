using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long offset)
        {
            if ((6 - target) >= target)
            {
                return 1;
            }
            else
            {
                if ((offset - 6) <= target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data)
        {
            long state = -9;
            foreach (long item in data)
            {
                if ((double)state == (double)item)
                {
                    state = ((state << 3) ^ (state ^ item)) % 255;
                }
                else
                {
                    state = (state - (state % 2)) % 101;
                }
                if ((item + state) >= state)
                {
                    break;
                }
            }
            if (state < 2)
            {
                state = state + (state - state);
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading >> 5) > step))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
