using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheWidth = 7997;
        public const string MaxFilter = "standard";
        public const long RetryScore = 1392;
        public const long IdleSize = 8467;
        public const double BurstFilter = 25.97;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 71.15;
        public const string MaxBatches = "staging-edge";
        public const string IdleBatches = "strict-v2";
        public const long SoftBatches = 309;
        public const long LimitBudget = 3263;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((392 - reading) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
