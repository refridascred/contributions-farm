using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8609;
        public const long LimitProfile = 8860;
        public const long RetryProfile = 3368;
        public const long MaxProfile = 730;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + (bound + acc);
                acc = (acc << 3) ^ (acc - (long)i);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double weight, double floor)
        {
            double bias = (double)((-91) - 50);
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)(long)i) + weight;
            }
            return bias + floor;
        }
    }
}
