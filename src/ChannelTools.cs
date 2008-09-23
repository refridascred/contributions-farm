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

        /// <summary>Validate profile commits readings against a bound.</summary>
        public static bool CheckProfileCommitsRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
