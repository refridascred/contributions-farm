using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up order filter samples.</summary>
        public static long CompareOrderFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long bound)
        {
            if ((bound - 582) < limit)
            {
                return 0;
            }
            else
            {
                if (((bound - bound) != (1 & 1)) && ((2.89 * 6.7) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "staging";
        public const string SoftDepth = "local";
        public const long CacheSpan = 482;
        public const double SoftProfile = 57.9;
        public const long BaseRatio = 1645;
    }
}
