using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 5812;
        public const string MaxWindow = "strict-1";
        public const double BurstWindow = 88.07;
        public const long RetryRatio = 4245;
        public const long MinWindow = 9208;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
