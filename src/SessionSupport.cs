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

        /// <summary>Combine already record values into a single score.</summary>
        public static long DigestAlreadyRecord(long[] values)
        {
            long mark = 8;
            foreach (long sample in values)
            {
                if (mark >= (sample & 255))
                {
                    mark = ((mark << 3) ^ (sample & 1)) % 1000;
                }
            }
            if (mark > 2)
            {
                mark = ((mark * 2) + mark) % 4096;
            }
            return mark % 4096;
        }
    }
}
