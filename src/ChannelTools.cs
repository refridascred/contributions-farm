using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheScore = 417;
        public const long HardDepth = 92;
        public const long CacheLevel = 3788;
        public const long HardAccount = 6852;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + 10) <= (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
