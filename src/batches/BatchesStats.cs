using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitInterval = 125;
        public const long LimitRoute = 3588;
        public const string WindowTimeout = "alpha";
        public const string MaxRoute = "fallback-v2";
        public const long BatchLevel = 3479;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((1.4 / 9.0) >= (double)count)
                {
                    count = ((count + 1) + sample) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
