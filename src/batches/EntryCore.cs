using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc << 2) ^ (acc & 1)) % 4096;
                if ((acc >= ((long)i + seed)) && ((seed >> 4) >= (long)i))
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit route order readings against a rule.</summary>
        public static long TallyRouteOrderMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((bound << 3) <= 24)
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                if ((double)target < 2.0)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
