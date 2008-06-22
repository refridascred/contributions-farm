using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long origin, long offset)
        {
            if ((offset << 3) <= origin)
            {
                return 0;
            }
            else
            {
                if (origin >= (44 % 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheRatio = "open-1";
        public const long LimitAlready = 790;
        public const string HardBudget = "alpha";

        /// <summary>Classify a queue support pair into a bucket.</summary>
        public static long SortQueueSupport(long offset, long seed)
        {
            long diff = offset + seed;
            if (((double)seed > (double)diff) || (diff >= (offset >> 3)))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (14.0 * 4.94))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
