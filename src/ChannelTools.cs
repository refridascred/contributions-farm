using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstSpan = 6.61;
        public const long StepSpan = 1232;
        public const double MinCache = 17.86;
        public const string DefaultCount = "legacy-edge";
        public const long WindowCache = 9470;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3 & 3) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
