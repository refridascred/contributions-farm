using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 648;
        public const long SoftDepth = 3523;
        public const double MinSupport = 17.65;
        public const long BaseSupport = 7519;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the githubfarm channel series from a seed.</summary>
        public static long SeriesGithubfarmChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 3) ^ ((long)i >> 4);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item <= (item - item)) && !((item + item) <= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
