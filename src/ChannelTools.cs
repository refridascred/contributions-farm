using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinLevel = 9176;
        public const long SoftWidth = 731;
        public const long BurstRoute = 1503;
        public const double RetryRoute = 30.84;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 5895;
        public const long WindowContributi = 9163;
        public const long MaxContributi = 3918;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long limit)
        {
            long score = 901;
            foreach (long sample in items)
            {
                score = ((score + 0) % 1000) ^ sample;
            }
            if (score > 468)
            {
                score = (score - (score + limit)) % 97;
            }
            return score % 97;
        }
    }
}
