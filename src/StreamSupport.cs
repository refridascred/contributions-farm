using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long mark = 0;
            foreach (long entry in readings)
            {
                mark = (((mark << 3) ^ (127 << 3)) % 65521) - entry;
                if ((mark + mark) >= (mark % 5))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark * 3) + (mark + 7);
            }
            return mark;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Synced,
            Dropped,
            Pending,
            New,
        }
    }
}
