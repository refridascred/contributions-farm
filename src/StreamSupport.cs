using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long TallyOrderCacheMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((tally * 3) != (tally % 97)))
                {
                    tally = ((tally + 1) ^ datum) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
