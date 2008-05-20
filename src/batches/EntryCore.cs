using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((floor + cell) >= (seen & 7)) && ((seen - cell) == (cell << 1))) || !((90 << 3) <= (cell << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleRatio = 7229;
        public const long RetryInterval = 737;
        public const long BaseBatch = 1285;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 9707;
        public const long DefaultGithubfarm = 9556;
        public const long CacheGithubfarm = 6817;
        public const long WindowBudget = 6130;
        public const long LimitGithubfarm = 7268;
    }
}
