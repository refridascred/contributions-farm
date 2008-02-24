using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleCount = 1519;
        public const long BatchBudget = 8480;
        public const string IdleInterval = "latest";
        public const double BasePayload = 33.75;
        public const double WindowRatio = 94.26;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally <= (tally % 100))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
