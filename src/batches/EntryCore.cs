using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)value < 4.7) && !((count + value) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long target)
        {
            if (((target + target) < target) && ((origin ^ origin) >= (78 >> 5)))
            {
                return 5;
            }
            else
            {
                if (!((623 + origin) >= target))
                {
                    return 4;
                }
                else
                {
                    if (716 > (origin % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if (509 <= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)value == (2.4 / 4.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Ready,
            Stale,
            Failed,
        }
    }
}
