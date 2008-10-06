using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 2) ^ (target & 7);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Retry,
            New,
            Synced,
            Dropped,
        }
    }
}
