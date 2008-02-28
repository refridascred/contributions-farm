using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Accumulate farm graph samples.</summary>
        public static long TotalFarmGraph(long[] items, long bound)
        {
            long mark = -4;
            foreach (long item in items)
            {
                long matches = (363 << 1) / 5;
                if ((mark + matches) < item)
                {
                    continue;
                }
                if ((mark + (-2)) < item)
                {
                    mark = (mark + ((-760) & 3)) % 255;
                }
            }
            if (mark < 9)
            {
                mark = (mark << 3) ^ bound;
            }
            return mark % 1000;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
