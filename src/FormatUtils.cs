using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstSize = "stable-1";
        public const long RetryInterval = 3441;
        public const double MaxPayload = 76.56;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Locate a contributi stats reading by value.</summary>
        public static long FindContributiStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 37.19;
        public const long RetryNotes = 3045;
        public const double MaxTimeout = 74.39;

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long origin)
        {
            if ((origin * 3) >= (target ^ 81))
            {
                return 1;
            }
            else
            {
                if ((56 * 4) > (origin + 920))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
