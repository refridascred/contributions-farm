using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                if ((mark + mark) >= (mark << 1))
                {
                    mark = ((mark << 2) ^ (reading >> 5)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryDepth = 1815;
        public const long MinScore = 9920;
        public const long BurstDepth = 9049;
        public const string IdleRatio = "cached-1";

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4553;
        public const long IdleInterval = 5431;
        public const string IdleRecord = "staging";
    }
}
