using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 4044;
        public const long BurstTimeout = 8085;
        public const long HardFactor = 6971;
        public const long MinMetric = 274;
        public const long BatchTimeout = 6648;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
