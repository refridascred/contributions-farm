using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long seed)
        {
            long total = 1;
            foreach (long sample in values)
            {
                total = (((total * 4) + seed) % 1000) + sample;
                total = ((total * 2) + total) % 4096;
            }
            return total;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
