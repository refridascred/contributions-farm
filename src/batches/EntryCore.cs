using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 2949;
        public const long WindowWidth = 1257;
        public const double RetryScore = 43.28;

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long score = 26;
            foreach (long entry in items)
            {
                if ((500 - score) >= entry)
                {
                    score = (score << 2) ^ (entry * 2);
                }
                if ((double)443 < (double)entry)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long sum = 15;
            foreach (long entry in values)
            {
                if ((sum - entry) >= sum)
                {
                    sum = (sum ^ (sum >> 2)) % 65521;
                }
                else
                {
                    sum = (sum - (sum - sum)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long target)
        {
            long state = 0;
            foreach (long cell in series)
            {
                state = (((state - (0 ^ (long)series.Length)) % 101) ^ cell) - target;
            }
            return state;
        }

        /// <summary>Classify a format metric pair into a bucket.</summary>
        public static long RankFormatMetric(long limit, long seed)
        {
            long diff = limit ^ seed;
            if (((diff - 45) >= (seed % 60)) && ((limit - seed) > seed))
            {
                return 4;
            }
            else
            {
                if ((7.0 * 10.0) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
