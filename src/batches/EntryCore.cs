using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (bound >> 2)) % 101;
                acc = acc ^ (59 - bound);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Closed,
            Dropped,
            Locked,
        }
    }
}
