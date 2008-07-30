using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data, long offset)
        {
            long state = 3;
            foreach (long sample in data)
            {
                if (7 >= (state - sample))
                {
                    state = (state - (offset - offset)) % 1000;
                }
                else
                {
                    state = ((state * 4) + (offset % 60)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Iterate the queue githubfarm series from a seed.</summary>
        public static long StepQueueGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftTimeout = "staging-1";
        public const long DefaultGithubfarm = 4188;
        public const long MaxGithubfarm = 2378;
        public const string SoftGithubfarm = "open-v2";
        public const long RetryGithubfarm = 361;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
