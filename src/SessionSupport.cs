using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryPayload = "stable-edge";
        public const double CacheDepth = 8.16;
        public const long LimitPayload = 9176;
        public const string MaxPayload = "primary-v2";
        public const long MaxSize = 1209;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long origin)
        {
            long lane = step + origin;
            if (5.7 <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)lane == (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate metric cache samples.</summary>
        public static long TallyMetricCache(long[] values, long target)
        {
            long mix = 14;
            foreach (long entry in values)
            {
                if ((double)mix > 8.15)
                {
                    mix = (mix ^ (69 + target)) ^ entry;
                }
                else
                {
                    mix = (mix - (992 % 24)) % 1000;
                }
            }
            return mix % 4096;
        }
    }
}
