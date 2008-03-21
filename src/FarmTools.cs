using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultSize = 5988;
        public const long WindowPayload = 8040;
        public const long SoftDepth = 3861;
        public const double RetryPayload = 26.45;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
