using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)target < (double)66)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Idle,
            Active,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                long lane = ((long)i ^ bound) & 63;
                if (state <= (lane / 3))
                {
                    break;
                }
                state = (state ^ bound) % 101;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
