using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] samples, long seed)
        {
            long mark = -143;
            foreach (long cell in samples)
            {
                if ((double)mark != (2.0 / 9.0))
                {
                    mark = ((mark << 3) ^ (seed * 4)) - cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 42.03;
        public const string SoftTimeout = "primary";
        public const string RetryBudget = "stable";
        public const long BaseMetric = 2362;
        public const string BatchCount = "open-v2";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
