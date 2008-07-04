using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 3754;
        public const long SoftDepth = 9632;
        public const long BaseEntry = 8251;
        public const long CacheEntry = 8113;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long seed)
        {
            if ((double)limit < 3.0)
            {
                return 1;
            }
            else
            {
                if ((limit + limit) > (seed + limit))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit * 4) > total)
                {
                    total = total - (limit << 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 5)) % 4096;
                    total = (total - (total % 100)) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
