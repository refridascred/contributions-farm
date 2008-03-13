using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally >= 86)
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
