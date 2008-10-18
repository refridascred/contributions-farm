using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long origin, long target)
        {
            if ((target > (origin >> 2)) && ((689 + target) == (99 * 5)))
            {
                return 0;
            }
            else
            {
                if ((4 + origin) <= target)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count route cache pairs that satisfy a relation.</summary>
        public static long MatchRouteCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
