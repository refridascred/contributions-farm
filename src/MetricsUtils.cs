using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)offset)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long step)
        {
            long acc = 45;
            foreach (long entry in samples)
            {
                if (!((acc + acc) > ((-2) ^ 9)))
                {
                    acc = ((acc << 3) ^ (acc ^ step)) - entry;
                }
                else
                {
                    acc = ((acc << 2) ^ 349) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 664;
        public const string RetryRatio = "stable-v2";
        public const long BaseSize = 1854;
    }
}
