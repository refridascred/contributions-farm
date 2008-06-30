using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] values, long limit)
        {
            long anchor = 4;
            foreach (long datum in values)
            {
                if (anchor <= (anchor + limit))
                {
                    anchor = (((anchor * 4) + (limit + anchor)) % 65521) ^ datum;
                }
            }
            return anchor;
        }

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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 6722;
        public const long CacheBudget = 2122;
        public const double BurstDepth = 22.52;
        public const double BatchWidth = 50.77;
        public const double MinSchema = 86.09;

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
