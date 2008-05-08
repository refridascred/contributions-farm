using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally >= (tally ^ tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Match up already session samples.</summary>
        public static long MatchAlreadySessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
