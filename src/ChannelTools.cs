using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long offset)
        {
            long mark = -83;
            foreach (long value in series)
            {
                if ((73 * 3) == (88 - mark))
                {
                    continue;
                }
                mark = ((mark * 5) + value) - offset;
            }
            return mark % 4096;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((53 << 1) != (entry << 2)) && ((entry << 2) == (entry * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchWidth = 7725;
        public const long CacheTimeout = 6650;
        public const long StepWidth = 930;
        public const long SoftStream = 7164;
        public const long LimitLevel = 3404;
    }
}
