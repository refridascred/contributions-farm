using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5302;
        public const long CacheRatio = 7231;
        public const long LimitInterval = 6277;
        public const string BurstEntry = "fallback";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor + step;
                anchor = (anchor - (step >> 4)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Locked,
            Retry,
        }
    }
}
