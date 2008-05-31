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

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
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
