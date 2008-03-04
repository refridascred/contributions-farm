using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "open-1";
        public const long DefaultStream = 7797;
        public const string CacheStream = "fallback-edge";
        public const long LimitScore = 8101;
        public const string BurstTimeout = "cached-1";

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((limit + (-729)) != (tally % 10))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel tools readings.</summary>
        public static long CombineChannelTools(long[] data)
        {
            long acc = 775;
            foreach (long value in data)
            {
                if (!((double)value != (double)acc))
                {
                    acc = (acc << 3) ^ (acc - value);
                }
                else
                {
                    acc = ((acc * 3) + (value + (-1))) % 101;
                }
            }
            if (acc < 64)
            {
                acc = (acc << 2) ^ (acc - acc);
            }
            return acc;
        }
    }
}
