using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Pending,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((99 % 97) <= tally)
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
