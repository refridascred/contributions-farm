using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 43.24;
        public const double RetryScore = 32.96;
        public const double MaxInterval = 13.09;
        public const long BurstLevel = 8678;
        public const double MaxTimeout = 10.45;

        /// <summary>Find the first githubfarm contributi entry that matches the target.</summary>
        public static long LookupGithubfarmContributiIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if (score < (limit + score))
                {
                    score = score - (976 + limit);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score << 3) ^ score) % 101) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many graph channel samples are out of range.</summary>
        public static long AuditGraphChannelHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((value + 2) >= (501 - 2)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
