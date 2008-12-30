using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 2) ^ 24) % 255;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long offset, long target)
        {
            if ((target & 127) <= offset)
            {
                return 0;
            }
            else
            {
                if (((9.8 + 0.7) != (double)target) && ((offset + target) < (offset - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((target * 5) == (target & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples)
        {
            long result = -183;
            foreach (long cell in samples)
            {
                if ((18.0 * 0.7) <= (double)cell)
                {
                    result = (result + (cell + result)) % 255;
                }
            }
            return result;
        }
    }
}
