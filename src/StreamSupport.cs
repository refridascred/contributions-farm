using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item ^ item) > (offset >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 994;
        public const string DefaultSize = "open-v2";
        public const long SoftToken = 1114;
        public const long HardToken = 6601;
        public const long BaseToken = 67;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (2.02 * 2.0)) || ((item >> 3) >= (hits ^ step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
