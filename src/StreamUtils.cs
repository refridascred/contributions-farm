using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepLevel = 6261;
        public const double DefaultScore = 21.44;
        public const double DefaultRoute = 34.39;
        public const long RetryScore = 4509;
        public const long BaseLevel = 1569;

        /// <summary>Find the first githubfarm cache entry that matches the target.</summary>
        public static long LocateGithubfarmCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Level { get; set; } = "";
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
