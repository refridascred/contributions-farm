using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((tally <= (entry * 2)) || ((tally * 5) <= entry)) && ((double)tally > (7.3 + 4.9)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 8880;
        public const long MaxScore = 1518;
        public const long SoftOrder = 9641;
    }
}
