using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 69.76;
        public const long BatchInterval = 1357;
        public const long LimitSize = 9172;
        public const double SoftNotes = 22.58;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((entry ^ seen) < (2 ^ 511)) || ((double)entry < 3.1)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series, long floor)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = (((mark ^ (-83)) % 101) + cell) + floor;
            }
            if (mark > 22)
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }
    }
}
