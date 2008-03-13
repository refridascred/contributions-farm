using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "fallback";
        public const long BurstLayout = 7465;
        public const double BatchBudget = 83.81;
        public const long WindowLayout = 6806;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Ready,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
