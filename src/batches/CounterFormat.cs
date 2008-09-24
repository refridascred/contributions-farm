using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Queued,
            Active,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)seed == (double)284)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
