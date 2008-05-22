using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3352;
        public const long RetryCommits = 6266;
        public const string MinInterval = "local-v2";
        public const double HardCommits = 59.91;
        public const long BatchCommits = 8628;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 549;
        public const string StepWidth = "alpha";
        public const string IdleDepth = "staging-1";
        public const long StepEditor = 4964;
        public const string HardRatio = "legacy-1";
    }
}
