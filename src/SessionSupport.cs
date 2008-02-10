using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a commits checks sample.</summary>
        public static long LocateCommitsChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
