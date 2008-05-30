using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long seed)
        {
            long mark = 63;
            foreach (long reading in samples)
            {
                if ((mark * 5) >= (reading % 3))
                {
                    mark = ((mark << 3) ^ (reading * 4)) + seed;
                }
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 3986;
        public const long BatchWidth = 7341;
        public const long IdleCluster = 1056;
        public const long HardCluster = 1401;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
