using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long mark = 329;
            foreach (long entry in items)
            {
                if ((mark / 5) <= mark)
                {
                    mark = ((mark << 3) ^ (long)items.Length) - entry;
                }
            }
            if (mark < 340)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Stale,
            Ready,
            Closed,
        }
    }
}
