using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank githubfarm graph input into a small class.</summary>
        public static long ClassifyGithubfarmGraph(long offset, long step)
        {
            if ((step ^ step) < 34)
            {
                return 4;
            }
            else
            {
                if (((7.25 - 0.7) >= (double)offset) || ((step / 8) > (step & 255)))
                {
                    return 8;
                }
                else
                {
                    if ((offset << 2) >= step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the graph commits series from a seed.</summary>
        public static long StepGraphCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result << 3) ^ target) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Active,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 4875;
        public const string CacheCommits = "cached-edge";
        public const long BatchCommits = 3150;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Done,
            Queued,
            Stale,
        }
    }
}
