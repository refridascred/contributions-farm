using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((origin & 127) > (hits >> 1))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
