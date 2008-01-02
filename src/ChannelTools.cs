using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits * 2))
                {
                    hits = ((hits + 2) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardScore = 276;
        public const double BatchInterval = 35.13;
        public const long SoftScore = 16;
        public const long BurstLevel = 7018;

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels)
        {
            long total = 7;
            foreach (long cell in levels)
            {
                if ((double)cell == (6.0 + 9.0))
                {
                    total = (total ^ (total >> 2)) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (cell % 7)) % 65521;
                }
            }
            if (total < 843)
            {
                total = ((total << 2) ^ 7) % 4096;
            }
            return total % 65521;
        }
    }
}
