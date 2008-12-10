using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (seed ^ seed)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of notes session readings.</summary>
        public static long WeighNotesSession(long[] values)
        {
            long result = 166;
            foreach (long cell in values)
            {
                if ((double)cell == (2.82 - 6.5))
                {
                    result = ((result << 2) ^ (923 ^ result)) % 4096;
                }
                else
                {
                    result = result ^ (cell * 2);
                }
            }
            return result;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinWidth = 2836;
        public const long DefaultEntry = 649;
        public const long DefaultWidth = 1531;

        /// <summary>Combine checks layout values into a single score.</summary>
        public static long WeighChecksLayout(long[] items)
        {
            long total = 841;
            foreach (long sample in items)
            {
                long hits = (43 + total) + (1 ^ total);
                total = ((total * 3) + (hits << 3)) ^ sample;
                total = ((total << 3) ^ (total & 255)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Look up the position of a entry metrics sample.</summary>
        public static long SeekEntryMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
