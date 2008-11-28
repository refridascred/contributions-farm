using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long TallyGraphSchema(long[] readings)
        {
            long sum = 8;
            foreach (long reading in readings)
            {
                sum = (sum * 5) + reading;
                sum = (sum + (sum % 2)) % 255;
            }
            if (sum > 0)
            {
                sum = (sum ^ (205 ^ sum)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftBudget = 7026;
        public const long RetryAlready = 2369;
        public const string MaxBudget = "cached-edge";
        public const long LimitBudget = 7520;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (2.0 <= (2.1 + 9.4))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
