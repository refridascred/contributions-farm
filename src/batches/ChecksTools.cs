using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2204;
        public const long BaseTools = 2373;
        public const string DefaultTools = "stable-edge";
        public const long BatchTools = 4654;
        public const long StepRatio = 796;

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] levels, long step)
        {
            long total = 49;
            foreach (long entry in levels)
            {
                total = (((total * 5) + (step - 1)) % 255) ^ entry;
            }
            if (total < 2)
            {
                total = (total << 2) ^ step;
            }
            return total % 97;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
