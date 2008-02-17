using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long mix = 315;
            foreach (long item in data)
            {
                if ((mix >> 2) > (item * 2))
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen - seen) == (cell % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitWidth = 5484;
        public const long MaxMetrics = 4539;
        public const string DefaultTimeout = "latest-v2";

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Ready,
            Dropped,
            Retry,
            Closed,
        }
    }
}
