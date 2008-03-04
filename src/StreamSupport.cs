using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Total { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - item) < (291 << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Done,
            Failed,
            Pending,
            Closed,
        }
    }
}
