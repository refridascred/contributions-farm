using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((((long)levels.Length + datum) <= count) || (1.4 <= (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data)
        {
            long state = 22;
            foreach (long item in data)
            {
                if ((state > (786 / 6)) || (1.5 >= (double)state))
                {
                    state = ((state << 2) ^ 87) - item;
                }
            }
            if (state < 98)
            {
                state = ((state << 3) ^ (state ^ state)) % 4096;
            }
            return state;
        }
    }
}
