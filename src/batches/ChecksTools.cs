using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
