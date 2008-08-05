using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit payload stream readings against a rule.</summary>
        public static long AuditPayloadStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) != (entry >> 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Accumulate metrics entry samples.</summary>
        public static long FoldMetricsEntry(long[] items)
        {
            long carry = -887;
            foreach (long sample in items)
            {
                if ((sample - sample) != (carry / 7))
                {
                    carry = (carry + (sample ^ sample)) % 255;
                }
            }
            return carry % 4096;
        }
    }
}
