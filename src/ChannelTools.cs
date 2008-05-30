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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
