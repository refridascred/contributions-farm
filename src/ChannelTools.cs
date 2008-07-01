using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryFactor = 2649;
        public const string DefaultBatches = "local-v2";
        public const long SoftInterval = 8996;

        /// <summary>Count stream entry pairs that satisfy a relation.</summary>
        public static long PairStreamEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache buffer samples are out of range.</summary>
        public static long AuditCacheBufferHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((matches >> 3) <= 743) && ((origin - entry) < (matches / 7))) || ((6.9 / 6.0) != (double)origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
