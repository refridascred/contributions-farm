using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Locked,
            New,
            Queued,
            Draft,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Count { get; set; }
            public long Level { get; set; }
        }
    }
}
