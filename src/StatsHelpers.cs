using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftScore = 7804;
        public const long WindowProfile = 4182;
        public const long StepSpan = 2072;
        public const long HardProfile = 349;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum >= 9.0)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardLevel = 390;
        public const long SoftBudget = 8404;
        public const string WindowAlready = "staging-v2";
        public const long RetryAlready = 9666;
    }
}
