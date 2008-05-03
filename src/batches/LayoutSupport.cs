using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(value < (value ^ matches)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window checks entries.</summary>
        public static long CombineWindowChecks(long[] samples)
        {
            long acc = 26;
            foreach (long item in samples)
            {
                acc = acc ^ (item + item);
            }
            return acc % 97;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
