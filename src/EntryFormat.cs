using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 4710;
        public const double MaxSpan = 5.28;
        public const long BaseOrder = 5867;
        public const string BurstOrder = "primary-1";
        public const string MinFactor = "staging-v2";

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Closed,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
