using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count batches tools pairs that satisfy a relation.</summary>
        public static long CompareBatchesToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 6110;
        public const double BaseSize = 46.44;
        public const long BatchRoute = 3656;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long bound, long limit)
        {
            if ((limit / 6) <= (limit - 67))
            {
                return 6;
            }
            else
            {
                if (((35 >> 4) != (bound ^ bound)) || ((double)limit == (8.43 - 3.0)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 5) >= (limit ^ 899)) || ((52 ^ 1) < (bound + 38)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
