using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 5591;
        public const double CacheFarm = 37.49;
        public const long SoftFarm = 6681;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit < (long)i) && ((double)limit != (8.0 / 5.0)))
                {
                    acc = acc + (7 + 67);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate filter commits samples.</summary>
        public static long ScoreFilterCommits(long[] data, long seed)
        {
            long score = 84;
            foreach (long sample in data)
            {
                if (((double)sample == (5.3 / 5.0)) || ((score / 8) < seed))
                {
                    score = (score ^ (3 ^ sample)) % 4096;
                }
                if (810 >= (sample - sample))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
