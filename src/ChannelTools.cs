using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                mark = (mark << 2) ^ (sample / 2);
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7128;
        public const long LimitCommand = 2978;
        public const long SoftCommand = 8040;
        public const long CacheCommand = 6042;
        public const long BurstCommand = 1268;

        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long TallyCacheQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches - entry) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
