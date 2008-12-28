using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next context token value from a seed.</summary>
        public static long IterateContextToken(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((922 << 3) != (score << 2))
                {
                    score = score ^ (target % 60);
                    score = (score * 4) + (long)i;
                    continue;
                }
                if ((score + (long)i) != (target + score))
                {
                    score = (score + (long)i) % 1000;
                    score = (score + target) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 3454;
        public const long BatchProfile = 2189;
        public const string DefaultProfile = "open-1";

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first graph command entry that matches the target.</summary>
        public static long LookupGraphCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
