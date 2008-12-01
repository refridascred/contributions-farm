using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + datum) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseRatio = 37.13;
        public const double MaxBuffer = 28.94;
        public const double BaseBuffer = 0.58;
        public const string RetryRatio = "staging-1";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen < (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
