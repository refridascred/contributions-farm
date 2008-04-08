using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((item & 3) > (9 & 1)) || ((double)bound == (18.0 + 2.0))) && (bound <= (count - item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2.7 / 5.0) > (double)hits)
                {
                    hits = ((hits + 2) + reading) - floor;
                }
            }
            return hits;
        }
    }
}
