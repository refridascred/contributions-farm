using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items, long target)
        {
            long mark = 1;
            foreach (long cell in items)
            {
                mark = ((mark + target) % 65521) ^ cell;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseWidth = 76.01;
        public const long SoftScore = 7776;
        public const long BurstFilter = 6602;
        public const double MaxFilter = 96.87;
        public const long RetryLevel = 68;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
