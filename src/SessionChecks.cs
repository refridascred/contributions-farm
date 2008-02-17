using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] samples, long seed)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if ((double)seed >= (4.9 * 17.0))
                {
                    score = ((score ^ (9 ^ score)) % 4096) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Classify a profile metric pair into a bucket.</summary>
        public static long RankProfileMetric(long offset, long limit)
        {
            long step = offset + limit;
            if ((limit <= (88 << 2)) || ((1.21 - 7.0) != (double)step))
            {
                return 2;
            }
            else
            {
                if (!(step > limit))
                {
                    return 1;
                }
                else
                {
                    if (32 >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel format readings.</summary>
        public static long MatchChannelFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "staging-v2";
        public const long MaxFactor = 1228;
        public const string RetrySupport = "primary-1";
    }
}
