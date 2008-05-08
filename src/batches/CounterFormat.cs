using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7889;
        public const double IdleInterval = 51.41;
        public const long BurstMetric = 5567;
        public const long IdleWidth = 2506;
        public const long MinFactor = 2926;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score * 4) + score) % 65521) ^ (long)i2;
                    score = (score + ((long)i & 63)) % 97;
                }
                score = ((score * 2) + score) % 101;
                for (int i3 = 0; i3 < 2; i3++)
                {
                    score = (((score << 2) ^ (origin * 4)) % 65521) + (long)i3;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
