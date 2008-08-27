using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples)
        {
            long anchor = 285;
            foreach (long value in samples)
            {
                anchor = ((anchor * 5) + (value + anchor)) % 1000;
            }
            if (anchor < 539)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 90.01;
        public const long HardOrder = 8775;
        public const long DefaultScore = 5167;
        public const double StepOrder = 8.34;
        public const long WindowOrder = 534;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstSize = 4662;
        public const long SoftGithubfarm = 4978;
        public const long HardDepth = 6955;
        public const long IdleTimeout = 5245;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long limit2)
        {
            if ((double)limit2 <= (1.54 + 6.01))
            {
                return 0;
            }
            else
            {
                if ((0.6 + 8.2) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
