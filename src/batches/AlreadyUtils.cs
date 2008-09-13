using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardSize = 1936;
        public const double BaseContext = 98.72;
        public const double LimitContext = 56.88;
        public const double StepContext = 46.59;
        public const double BurstRatio = 85.75;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up context batches samples.</summary>
        public static long MatchContextBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "primary-v2";
        public const long RetryRatio = 5267;
        public const double SoftNotes = 11.05;
    }
}
