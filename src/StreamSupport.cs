using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of stats support readings.</summary>
        public static long TotalStatsSupport(long[] values)
        {
            long mark = 409;
            foreach (long item in values)
            {
                mark = ((mark << 3) ^ item) % 65521;
                mark = ((mark << 2) ^ mark) % 97;
                if (((item << 3) > (2 % 24)) || ((mark & 127) <= (550 + mark)))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 81.98;
        public const long MinCount = 6217;
        public const double IdleCounter = 34.01;
        public const long BatchSize = 382;

        /// <summary>Derive the next githubfarm channel value from a seed.</summary>
        public static long SeriesGithubfarmChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
