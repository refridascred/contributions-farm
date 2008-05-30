using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 63.5;
        public const long BurstLevel = 9381;
        public const string LimitSize = "local-1";
        public const long BurstTimeout = 3495;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the queue filter series from a seed.</summary>
        public static long StepQueueFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i >= 2.5)
                {
                    score = (score - limit) % 101;
                    score = (score * 5) + ((long)i >> 4);
                }
                if (((long)i + score) <= (limit + score))
                {
                    score = ((score * 4) + score) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
