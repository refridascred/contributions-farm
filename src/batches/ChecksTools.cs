using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((2 <= (matches + seed)) || ((712 >> 3) == (seed + matches))) && (seed >= matches))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples, long target)
        {
            long acc = 482;
            foreach (long reading in samples)
            {
                acc = acc + (target / 6);
                acc = (acc + (reading + target)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((9.15 / 7.0) < (double)entry)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
