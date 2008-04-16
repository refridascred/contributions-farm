using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long offset)
        {
            long anchor = 345;
            foreach (long sample in levels)
            {
                if ((double)anchor == (8.79 + 4.0))
                {
                    anchor = (((anchor << 3) ^ 7) + sample) - offset;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5861;
        public const long IdleGithubfarm = 2648;
        public const string CacheWidth = "fallback-1";
        public const string BaseGithubfarm = "standard";

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if (acc >= 7)
                {
                    acc = (acc * 4) + step;
                    acc = (acc + step) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Closed,
            Paused,
        }
    }
}
