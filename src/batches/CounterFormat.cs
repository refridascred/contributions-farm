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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen * 2) > reading)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }
    }
}
