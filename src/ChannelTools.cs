using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 596;
        public const double BatchStream = 12.78;
        public const string CacheStream = "standard-v2";
        public const long IdleDepth = 5898;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long target, long bound)
        {
            long bound2 = target ^ bound;
            if ((bound2 / 7) >= bound)
            {
                return 7;
            }
            else
            {
                if (((-6) + bound2) <= 10)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound > (8.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound > (9 / 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
