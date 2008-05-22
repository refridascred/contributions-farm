using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 469;
        public const double WindowDepth = 26.33;
        public const long LimitOrder = 1573;
        public const double CacheScore = 15.76;
        public const long LimitSpan = 4097;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
