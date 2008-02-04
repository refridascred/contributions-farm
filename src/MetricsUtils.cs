using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchRatio = 6001;
        public const string MaxLevel = "fallback";
        public const double LimitScore = 69.73;
        public const long RetryBudget = 4815;
        public const long RetryRatio = 1904;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Done,
            New,
            Pending,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches < (1.0 - 1.0))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first batches schema entry that matches the target.</summary>
        public static long FindBatchesSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
