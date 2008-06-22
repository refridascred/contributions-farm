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

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstLevel = 714;
        public const long RetryLevel = 5195;
        public const long WindowScore = 2614;
        public const double RetryCount = 70.3;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Dropped,
            Stale,
        }

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
