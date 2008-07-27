using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchBudget = "primary-1";
        public const string IdleRatio = "stable";
        public const long MaxCommand = 4956;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((limit * 2) == (matches << 1)))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples, long step)
        {
            long total = -294;
            foreach (long value in samples)
            {
                total = ((total ^ (value << 1)) % 1000) + step;
            }
            if (total > 77)
            {
                total = total - (total + 15);
            }
            return total;
        }
    }
}
